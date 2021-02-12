<?php


namespace app\models\Entities;

/**
 * Description of menuproduct
 *
 * @author roman
 */

class pdb {
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