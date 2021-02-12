<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models\Entities;

/**
 * 
 *
 * @author roman
 */
class ppp {
    public $remoteid;
    public $name;
    public $categid;
    public $wp;

    public function __construct($rbean)
    {
        $this->remoteid = $rbean->id;
        $this->name = $rbean->name;
        $this->categid = $rbean->category;
        $this->wp = $rbean->wpinfo;
    }
}
