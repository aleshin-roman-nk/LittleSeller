<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\controllers;
use app\models\ShiftMenu;

/**
 * Description of ShowmenuController
 *
 * @author roman
 */
class ShowmenuController extends AppController{
    public function indexAction(){
        \fw\core\Db::instance();
              
        $shiftmenu = new ShiftMenu();
        
        if(isset($_GET['date'])){
            $shiftmenu->setDateFromStr($_GET['date']);
        }

        $showitems = $shiftmenu->getShowingMenu();
        
        $this->set(compact('showitems', 'shiftmenu'));
    }
    
    public function chdtAction(){
        
        $url = '/';
        
        $shift = new ShiftMenu();
        if(isset($_GET['date'])){
            $shift->setDateFromStr($_GET['date']);
        }
        
        if(isset($_GET['cmd'])){
            if($_GET['cmd'] == 'prev'){
                $shift->prevDay();
                $url .= "?date={$shift->getName()}";
            }else if($_GET['cmd'] == 'now'){
                $shift = new ShiftMenu();
                $url .= "?date={$shift->getName()}";
            }else if($_GET['cmd'] == 'next'){
                $shift->nextDay();
                $url .= "?date={$shift->getName()}";                
            }
        }
        
        redirect($url);
    }
}
