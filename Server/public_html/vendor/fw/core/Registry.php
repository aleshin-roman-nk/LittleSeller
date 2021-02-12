<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace fw\core;

/**
 * Description of Registry
 *
 * @author roman
 */
class Registry {
    
    use TSingletone;
    
    public static $objects = [];
//    protected static $instance;
    protected function __construct() {
        
        require ROOT . '/config/config.php';
        
        foreach ($config['components'] as $name => $component){
            self::$objects[$name] = new $component;
        }
        
    }

//    public static function instance() {
//        if (self::$instance === null) {
//            self::$instance = new self;
//        }
//
//        return self::$instance;
//    }

    public function __get($name) {
        if(is_object(self::$objects[$name])){
            return self::$objects[$name];
        }
    }
    
    public function __set($name, $obj) {
        if(!isset(self::$objects[$name])){
            self::$objects[$name] = new $obj;
        }
    }
    
    public function getList(){
        echo '<pre>';
        var_dump(self::$objects);
        echo '</pre>';
    }
}
