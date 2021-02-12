<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models\Entities;

/**
 * Description of menuproduct
 *
 * @author roman
 */
class menuproduct {
    public $id;
    public $name;
    public $wp;
    public $categid;
    public $srcid;
    public $balance;
    public $shiftid;
    
    public function __construct($id, $name, $wp, $categid, $srcid, $balance, $shiftid) {
        $this->id = $id;
        $this->name = $name;
        $this->wp = $wp;
        $this->categid = $categid;
        $this->srcid = $srcid;
        $this->balance = $balance;
        $this->shiftid = $shiftid;
    }
}
