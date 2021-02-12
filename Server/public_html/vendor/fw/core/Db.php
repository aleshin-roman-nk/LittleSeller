<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace fw\core;

/**
 * Description of Db
 *
 * @author roman
 */
class Db {
    
    use TSingletone;
    
    protected $pdo;
    
    public static $countSql = 0;
    public static $queries = [];

    protected function __construct() {
        require LIBS . '/rb-mysql.php';
        $db = require '../config/config_db.php';
        \R::setup($db['dsn'], $db['user'], $db['pass']);
    }
}
