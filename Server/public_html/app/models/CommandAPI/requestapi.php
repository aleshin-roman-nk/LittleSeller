<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 * 
 * 
 * Необходимо составлять документацию API для работы с этим сервисом
 */

namespace app\models\CommandAPI;



/**
 * Description of requestapi
 *  Возвращает ответ в виде json строки
 * @author roman
 */
class requestapi {
    
    private $success = 'success';
    private $errTransactionAlready = 4;
    
    public function go(){// Создать маршрутизатор, пришла транзакция на выполнениеили просто запрос gkey например
        
        if (!isset($_GET['j'])) {
            return 'Value "j" not found';
        }

        $obj = json_decode($_GET['j']);

        if(!isset($obj)) return 'There is not json';
        if (!property_exists($obj, 'cmd')) return '"cmd" not found in json structure';
        
        //еще добавить проверку на типа data, но это уже в соотвутствующем методе
        // в data должно быть поле type, в котором отметка соответствия типа
        
        $m = $obj->cmd . '_cmd';
        
        // Ошибка оказалась, на самом деле метод reg_receipt_cmd определен, но без кода
        if (!method_exists($this, $m)) {
            return (new Response("", 100, 'Request name ' . $obj->cmd . ' is not exist'))->ToJSON();
        }

        initRedBeanPHP();
        
        // 1. Особая команда - получение gkey, создать и вернуть
        // Гарантия, что сервер никогда не выдаст одинаковые идентификаторы
        if("get_gkey" ===  $obj->cmd){
            return $this->get_gkey_cmd(null);
        }
                
        // 2. Если транзакция уже выполнена, вернуть ошибку
        if ($this->checkTransaction($obj->gkey)) {
            return (new Response("", $this->errTransactionAlready, "Transaction [" . $obj->gkey . "] already exists"))->ToJSON();
        }

        // 3. Выполнение транзакции
        if (!isset($obj->data)) {
            $obj->data = null;
        }
        $response = $this->$m($obj->data);

        // 4. Зарегистрация выполнения транзакции
        $this->registerTransaction($obj->gkey);
        
        return $response;
    }
    
    function conn_text_cmd($data){
        return (new Response("ok", 0, null))->ToJSON();
    }
    
    function get_gkey_cmd($data){
        
        $lastuid = \R::findOne('vals', 'name = ?', ['lastuid']);
        
        (int)$lastuid->val++;
        
        \R::store($lastuid);
        
        $res = $lastuid->val;
        
        return "{head:'json', data:".$res."}";
    }
    
    function checkTransaction($gkey){
        // лезем в таблицу выполненных транзакций и проверяем наличие gkey.
        $gk = \R::findOne('transactions', 'gkey = ?', [$gkey]);
        if(isset($gk))
            return true;
        else return false;
    }    
    function registerTransaction($gkey){
                
        $g = \R::dispense('transactions');
        
        $g->gkey = $gkey;
        $g->completed = true;
        
        \R::store($g);        
    }    
    
    // Создать класс описатель таблиц бд, набор констант, и по всему проекту пользоваться переменными именами а не строками с именами таблиц
    function reg_receipt_cmd($data){
        
        $new_receipt = \R::dispense('receipts');


        $new_receipt->shiftid = $data->ShiftId;
        $new_receipt->date = $data->DateMySQL;
        $new_receipt->amount = $data->Amount;
        
        \R::store($new_receipt);
        
        $items = $data->ReceiptItems;
        
        foreach ($items as $receipt_item) {
            $new_receipt_item = \R::dispense('receiptitems');
            
            $new_receipt_item->typeid = $receipt_item->TypeId;
            $new_receipt_item->receiptid = $new_receipt->id;
            $new_receipt_item->menuitemid = $receipt_item->MenuItemId;
            $new_receipt_item->categoryid = $receipt_item->CategoryId;
            $new_receipt_item->name = $receipt_item->Name;
            $new_receipt_item->price = $receipt_item->Price;
            $new_receipt_item->count = $receipt_item->Count;
            $new_receipt_item->discprice = $receipt_item->DiscPrice;
            $new_receipt_item->weight = $receipt_item->Weight;
            
            \R::store($new_receipt_item);
        }
        
        // Пока без смен... Чек имеет дату, есть возможность выводить дневной отчет.
        
        // Теперь регистрировать привязанные к объекту подобъекты
        // Помещение в базу сложного объекта и извлечение - две целостные операции.
        // 
        // 
        // 
       // $receiptPositions = $data->ReceiptItems;
        
        //foreach ($receiptPositions as $pos) {
            
        //}
        
        return (new Response("", 0, "Receipt is registered id = $new_receipt"))->ToJSON();
    }
    
    
    
    
    
    
    function get_roman_cmd($data){
        //sleep(2);
        // Регистрируем исполнение транзакции.
        // И помещаем номер gkey транзакции в таблицу выполненных транзакций.
        
        //return "{head:'json', data:'Roman', error_code:0}";
               

        return (new Response("Roman", 0, ""))->ToJSON();
    }
    
    function get_shiftmenu_cmd($data){
        
        $shift = \R::findOne('shiftmenu', 'name = ?', [$data]);
        
        $res = [];
                
        $menuitems = \R::find('menut', 'shiftid = ?', [$shift->id]);
        
        if(!isset($menuitems)) return json_encode(make_response('error', $res, 'get_shiftmenu' ));
        
        foreach ($menuitems as $k) {
          $res[] = new menuitem($k);
        }
        
        return "shift menu kotoroe Olia nabrala";
    }
}

class Response{
    public $head = 'json';
    public $error_code;
    public $error_msg;
    public $data;
    
    /**
     * @param $d - data
     * @param $ec - error code
     * @param $em - error message
     */
    public function __construct($d, $ec, $em) {
        $this->data = $d;
        $this->error_code = $ec;
        $this->error_msg = $em;
    }
    
    public function ToJSON(){
        return json_encode($this);
    }
}

class menuitem{
    
    public $id;
    public $name;
    public $category;
    public $srcid;
    public $balance;
    public $shiftid;
    public $discount;
    public $wpinfo;
    
    public function __construct($bean) {
        $this->id = $bean->id;
        $this->name = $bean->name;
        $this->category = $bean->category;
        $this->srcid = $bean->srcid;
        $this->balance = $bean->balance;
        $this->shiftid = $bean->shiftid;
        $this->discount = isset($bean->discount) ? $bean->discount : 0;
        $this->wpinfo = $bean->wpinfo;
    }
}

class srcitem{
    
    public $id;
    public $name;
    public $category;
    public $wpinfo;
    
    public function __construct($bean) {
        $this->id = $bean->id;
        $this->name = $bean->name;
        $this->category = $bean->category;
        $this->wpinfo = $bean->wpinfo;
    }
}