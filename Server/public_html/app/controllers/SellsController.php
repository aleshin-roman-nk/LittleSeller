<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\controllers;

/**
 * Description of Sells
 *
 * @author alesh
 */
class SellsController extends AppController {
    
    public $layout = 'sells';
    
    public function indexAction(){
        
        \fw\core\Db::instance();
        
        $d = date('Y') . '-' . date('m') . '-' . date('d');        
        
        $coll = \app\models\ReceiptsInDay::GetReceipts($d);
                        
        $this->set(compact('coll', 'd'));
    }
}
