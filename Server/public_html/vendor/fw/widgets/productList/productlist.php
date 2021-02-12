<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace fw\widgets\productList;

/**
 * Description of productlist
 *
 * @author alesh
 */
class productlist {
    
    public $products;
    public $tpl;
    public $uri;
    
    public function __construct( $products ) {
        $this->products = $products;
        $this->tpl = __DIR__ . '/tpl/.php';
        $this->uri = $this->getParams();
    }
    
    protected function getHtmlRow($product) {

        $r = "<tr>" .
        "  <th scope='row'>{$product['id']}</th>" .
        "  <td>{$product['name']}</td>" .
        "  <td>{$product['category']}</td>" .
        "  <td>{$product['weight']}</td>" .
        "  <td>{$product['price']}</td>" .
        "  <td><a href='/?add_product={$product['id']}' class='btn btn-block btn-success'>+</a></td>" .
        "</tr>";
       return $r;
       
       // Может еще одним параметром отдавать уже сформированную строку со всеми параметрами
    }
    
    protected function getHtml($products){
        $table_content = '';
        
        if (!empty($this->products)) {
            foreach ($this->products as $product) {
                $table_content .= $this->getHtmlRow($product);
            }
        }
        
        require $this->tpl;
    }

    protected function getParams() {
        $url = $_SERVER['REQUEST_URI'];

        $url = explode('?', $url);
        $uri = $url[0] . '?';
        if (isset($url[1]) && $url[1] != '') {
            $params = explode('&', $url[1]);
            foreach ($params as $param) {
                if (!preg_match("#product_id=#", $param)) {
                    $uri .= "{$param}&amp;";
                }
            }
        }
        return $uri;
    }

}
