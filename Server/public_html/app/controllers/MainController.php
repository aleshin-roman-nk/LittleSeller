<?php

namespace app\controllers;
use fw\core\App;
use fw\libs\Pagination;
use app\models\ShiftMenu;
use app\models\Category;
use app\models\Entities\ppp;
use app\models\Entities\pdb;



class MainController extends AppController {

//    public $layout = 'menu';
        
    public function indexAction(){
        
        //$this->layout = 'menu';        
        // Весь ниже код нужно переместить в модель. Кронтроллер не должен заниматься формированием данных.
        // Контроллер должен просто брать данные из модели(лей) и отдавать виду
        // Следует помнить, что строку с GET параметрами (в строке браузера) формирует клиент.
                
        

        \fw\core\Db::instance();
              
        $shiftmenu = new ShiftMenu();
       
        if(isset($_GET['date'])){
            $shiftmenu->setDateFromStr($_GET['date']);
        }
        
//        $ittems = $shiftmenu->getItemsByShift();
//        debug( json_encode($ittems, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT ) );
        

        $categs = Category::getCategs();
        $cid = isset($_GET['cat']) ? (int)$_GET['cat'] : 1;
        $ctitle = Category::getCat($cid);        
        
        $products = \R::find('menu', 'category = ? ORDER BY name asc', [$cid]);
        $menu = $shiftmenu->getMenuItems($cid);
            
        $this->set(compact('products', 'menu', 'categs', 'ctitle', 'shiftmenu'));
        
        \fw\core\base\View::setMeta('Меню', 'Создание меню', '');
        
        //$this->layout = false;
        //$this->layout = 'menu';
        //$this->view = 'show';
    }
    
    public function addAction(){
        $prodid = $_GET['product_id'];
      
        $shiftmenu = new ShiftMenu();
        $shiftmenu->setDateFromStr($_GET['date']);
        $shiftmenu->addProduct($prodid);
                
        //$_SESSION['productadded'] = "Продукт {$prodid} добавлен в меню";
                  
        $p = get_params_without_one('product_id');
        $url = "/main/index/?{$p}";
        
        redirect($url);
    }
    
    public function delAction(){
        \fw\core\Db::instance();
        
        $prodid = $_GET['product_id'];
        
        $m = \R::findOne('menut', 'id = ?', ["$prodid"]);
        
        \R::trash($m);
        
        //$_SESSION['productadded'] = "Продукт {$m->name} удален из меню";
                
        $p = get_params_without_one('product_id');
        $url = "/main/index/?{$p}";
        
        redirect($url);
    }
    
    public function vmAction(){
       
        \fw\core\Db::instance();
        
        $menutoday = \R::findAll('menut');
        
        $this->set(compact('menutoday'));
    }
        
    public function prevAction(){
        $s = new ShiftMenu();
        
        if(isset($_GET['date'])){
            $s->setDateFromStr($_GET['date']);
        }
        
        $s->prevDay();
        
        $url = change_one_param('/main/index/', 'date', $s->getName());
        
        redirect($url);
    }
    
    public function nextAction(){
        $s = new ShiftMenu();
        
        if(isset($_GET['date'])){
            $s->setDateFromStr($_GET['date']);
        }
        
        $s->nextDay();
                
        $url = change_one_param('/main/index/', 'date', $s->getName());
        
        redirect($url);        
    }
       
}
