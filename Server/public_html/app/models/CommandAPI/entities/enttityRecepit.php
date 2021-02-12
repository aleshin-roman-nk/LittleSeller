<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models\CommandAPI\entities;

/**
 * Description of enttityRecepit
 *
 * @author alesh
 */
class Recepit {
    public $Id;
    public $ShiftId;
    public $Date;
    public $Closed;
    public $Card;
    public $urkey;
    public $Amount;
    
    public $ReceiptItems = [];
}

class ReceiptItem
{
    public $Id;
    public $TypeId;
    public $ReceiptId;
    public $MenuItemId;
    public $CategoryId;
    public $Name;
    public $Price;
    public $Count;
    public $DiscPrice;
    public $Weight;
}

class dbReceipt{
   
}