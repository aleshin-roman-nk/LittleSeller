<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models;

/**
 * Description of product
 *
 * @author alesh
 */
class product {
    public static function weight($wpinfo){
        $res = '';
        $wp = json_decode($wpinfo);
        
        if(!isset($wp)) return '-';
        
        foreach ($wp as $w => $p) {
            $res .= $w . ' / ';
        }
        
        return rtrim($res, ' / ');
    }
    public static function price($wpinfo){
        $res = '';
        $wp = json_decode($wpinfo);
        
        if(!isset($wp)) return '-';
        
        foreach ($wp as $w => $p) {
            $res .= $p . ' / ';
        }

        return rtrim($res, ' / ');
    }
}
