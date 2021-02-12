<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace fw\libs;

/**
 * Description of Cache
 *
 * @author roman
 */
class Cache {
    public function __construct() {
       
    }
    
    public function set($key, $data, $seconds = 3600){
        $content['data'] = $data;
        $content['end_time'] = time() + $seconds;
        if(file_put_contents(CACHE . '/' . md5($key) . '.txt', serialize($content))){
            return true;
        }
        return false;
    }    
    
    public function get($key){
        $fname = CACHE . '/' . md5($key) . '.txt';
        
        if(file_exists($fname)){
            $content = unserialize(file_get_contents($fname));
            if( time() <= $content['end_time']){
                return $content['data'];
            }
            unlink($fname);
        }
        return false;
    }
    
    public function delete($key){
        $fname = CACHE . '/' . md5($key) . '.txt';
        if(file_exists($fname)){
            unlink($fname);
        }  
    }
}
