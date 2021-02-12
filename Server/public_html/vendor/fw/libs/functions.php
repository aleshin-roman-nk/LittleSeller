<?php

function debug($arr, $die = false){
    echo '<pre>'. print_r($arr, true) .'</pre>';
    if($die) die;
}

function redirect($http = false){
    if($http){
        $redirect = $http;
    }else{
        $redirect = isset($_SEVER["HTTP_REFERER"]) ? $_SEVER["HTTP_REFERER"] : '/';
    }
    
    header("Location: $redirect");
    exit();
}

function h($str){
    return htmlspecialchars($str, ENT_QUOTES);
}

function get_params_without_one($oneparam){
    $url = $_SERVER['REQUEST_URI'];

    $url = explode('?', $url);
        
    //$uri = $url[0] .'?';
    $uri = '';
    if(isset($url[1]) && $url[1] != ''){
        $params = explode('&', $url[1]);
        foreach ($params as $param){
            if (!preg_match("#{$oneparam}=#", $param)) {
                $uri .= "{$param}&";
            }
        }
        $uri = rtrim($uri, '&');   
    }
    
    return $uri;
}

function get_all_params(){
    $url = $_SERVER['REQUEST_URI'];
    $url = explode('?', $url);
    
    $res = count($url) == 2 ? $url[1] : '';
    
    return $res;
}

/**
 * 
 * @param type $url
 * @param type $oneparam
 * @param type $value
 * @return type
 */
function change_one_param($url, $oneparam, $value){
    $p = get_params_without_one($oneparam);
    return "{$url}?{$p}&{$oneparam}={$value}";
}

function initRedBeanPHP(){
         require LIBS . '/rb-mysql.php';
        $db = require '../config/config_db.php';
        \R::setup($db['dsn'], $db['user'], $db['pass']);
}