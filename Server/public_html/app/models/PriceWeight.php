<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models;

/**
 * Description of PriceWeigth
 *
 * @author alesh
 */
class PriceWeight {

    // key - weight, value - price
    public $data = [];
    
    public function getJson(){
        return json_encode($this);
    }
}
