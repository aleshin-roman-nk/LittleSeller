<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models;

/**
 * Description of ReceiptsInDay
 *
 * @author alesh
 */
class ReceiptsInDay {
    
    public static function GetReceipts($date){
        // 1. Get all receipts by date
        // 2. Construct the collection of receipts
        
        $begin = $date . ' 00:00:00';
        $end = $date . ' 23:59:59';
        
        $coll = \R::find('receipts', 'date BETWEEN ? AND ?', [$begin, $end]);
        
        $res = new result_data();
        
        foreach ($coll as $receipt) {
            
            $r = new receipto();
            $r->date = $receipt->date;
            $r->amount = $receipt->amount;
            
            $receipt_items = \R::find('receiptitems', 'receiptid = ?', [$receipt->id]);
            foreach ($receipt_items as $rec_item){
                $r->items[] = $rec_item;
            }
            
            $res->collection[] = $r;
            $res->amount += $receipt->amount;
        }
        
        return $res;
    }
    
}

class receipto{
    public $date;
    public $amount;
    public $items = [];
}

class result_data{
    public $amount = 0;
    public $collection = [];
}
