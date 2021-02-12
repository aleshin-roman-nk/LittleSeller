<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of main_commands
 * Обработчик команд, поступающих на контроллер MainController
 *      хотя лучше для команд (запросы на всякие json-данные) выделить свой контроллер
 *      сервер может выдавать токены на идентификацию, чтобы всякие ненужные не могли получить инфу
 *      пост запросом требовать логин и пароль
 * @author roman
 */
class main_commands {
    
    /**
     * Пояснение
     * 
     * 
     * @param type $json_request 
     */
    public function get_response($json_request){
        
        
        
    }
    
    
    
    
    public function addprodAction(){
        $this->layout = false;
        echo 'Ok :';
        
        if (isset($_GET['product'])) {
            echo $j = $_GET['product'];

            \fw\core\Db::instance();

            $received = json_decode($j);

            $p = \R::dispense('menu');
            $p->name = $received->name;
            $p->category = $received->category;
            $p->wpinfo = json_encode($received->wp);
           
            \R::store($p);
        }
    }
    
    public function getallsrcAction() {
        $this->layout = false;

        if (isset($_GET['cmd'])) {
            if ($_GET['cmd'] == 'get_all_src_products') {

                \fw\core\Db::instance();

                $prods = \R::findAll('menu');

                $res = [];

                foreach ($prods as $item) {
                    $i = new ppp($item);
                    $res[] = $i;
                }

                echo json_encode($res, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
            }
        }        
        
    }

    public function getmenuAction(){
        $this->layout = false;

        if (isset($_GET['cmd']) && isset($_GET['name'])) {
            if ($_GET['cmd'] == 'get_menu') {

                $shid = $_GET['name'];
                
                \fw\core\Db::instance();

                $shmenu = \R::findOne('shiftmenu', 'name = ?', [$shid]);

                $res = [];
                
                if(!isset($shmenu)){
                    echo json_encode($res, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
                    die;
                }

                $menuItems = \R::find('menut', 'shiftid = ?', [$shmenu->id]);
                
                foreach ($menuItems as $item) {
                    $i = new ppp($item);
                    $res[] = $i;
                }

                echo json_encode($res, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
            }
        }        
    }    
    
    
    
}
