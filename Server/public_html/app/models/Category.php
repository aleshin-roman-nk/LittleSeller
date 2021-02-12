<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models;

/**
 * Description of Category
 *
 * @author alesh
 */
class Category {
    public static function getCategs(  ){
        \fw\core\Db::instance();
        return \R::findAll('category');
     
//        return \R::find('category', "id = ?", [$cid]);
    }
    
    public static function getCat($id){
        \fw\core\Db::instance();
        return \R::findOne('category', 'id = ?', [$id]);
    }
}
