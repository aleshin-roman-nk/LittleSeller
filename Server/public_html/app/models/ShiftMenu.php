<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models;

use app\controllers\UserController;

/**
 * Description of ShiftMenu
 *
 * @author alesh
 */
class ShiftMenu {
    
    public $id;
    public $dayName;
    
    private $date;

    
    protected $days = [
        1 => 'Понедельник',
        2 => 'Вторник',
        3 => 'Среда',
        4 => 'Четверг',
        5 => 'Пятница',
        6 => 'Суббота',
        7 => 'Воскресенье',
    ];    
        
    public function __construct() {       
        $this->setDate(date('Y'), date('m'), date('d'));
    }
    
    protected function setDate($year, $month, $day){
        $this->date = strtotime("{$year}-{$month}-{$day}");
        
        $this->dayName = $this->days[ date("N", $this->date) ];
        
        \fw\core\Db::instance();
        
        $p = \R::findOne('shiftmenu', 'name = ?', [$this->getName()]);
        if (!isset($p)) {
            $p = \R::dispense('shiftmenu');
            $p->name = $this->getName();
            \R::store($p);
        }

        $this->id = $p->id;
    }
    
    public function setDateWithoutCreate(){
        
    }
    
    public function setDateFromStr($strdate){
        $d = explode('.', $strdate);
        $this->setDate($d[2], $d[1], $d[0]);
    }
    
    protected function get_date_array(){       
       $res['y'] = date('Y', $this->date);
       $res['m'] = date('m', $this->date);
       $res['d'] = date('d', $this->date);
       
       return $res;
    }
    
    public function nextDay(){
       $dt = $this->get_date_array();
       $this->date = strtotime("+1 day", strtotime("{$dt['y']}-{$dt['m']}-{$dt['d']}"));
    }
    
    public function prevDay(){        
        $dt = $this->get_date_array();
        $this->date = strtotime("-1 day", strtotime("{$dt['y']}-{$dt['m']}-{$dt['d']}"));
    }
    
    public function getName(){       
       $dt = $this->get_date_array();
        
       return "{$dt['d']}.{$dt['m']}.{$dt['y']}";
    }
    
    public function toStr() {
        return $this->getName() . " / {$this->dayName}";
    }
    
    public function addProduct($prodid){
        \fw\core\Db::instance();

        $p = \R::findOne('menu', 'id = ?', ["$prodid"]);
        $m = \R::dispense('menut');
        
        $m->name = $p->name;
        $m->category = $p->category;
        $m->weight = $p->weight;
        $m->price = $p->price;
        $m->shiftid = $this->id;
        $m->srcid = $p->id;
        $m->balance = 0;
        $m->wpinfo = $p->wpinfo;
        
        \R::store($m);
    }
    
    public function getMenuItems($cat){
        return \R::find('menut', 'category = ? AND shiftid = ? ORDER BY name asc', [$cat, $this->id]);
    }
    
    public function getShowingMenu(){
        $categs = \R::findAll('category');
        
        $items = \R::find('menut', 'shiftid = ?', [$this->id]);
        
        $res = [];
                
        foreach ($categs as $categ) {
            foreach ($items as $item) {
                if ($item->category == $categ->id) {
                    $res[$categ->title][] = $item;
                }
            }
        }
        
        return $res;
    }
    
    public function getItemsByShift(){
        $items = \R::find('menut', 'shiftid = ?', [$this->id]);
        
        $res = [];
        
        foreach ($items as $v) {
            $res[] = new Enriries\menuproduct($v->id, $v->name, json_decode($v->wpinfo), $v->category, $v->srcid, $v->balance, $v->shiftid);
        }
        
        return $res;
    }
}
