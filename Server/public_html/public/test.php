<?php

require 'rb-mysql.php';
$db = require '../config/config_db.php';
R::setup($db['dsn'], $db['user'], $db['pass']);
R::fancyDebug(TRUE);

//$cat = R::dispense('category');
//$cat->title = "Категория 1";
//$id = R::store($cat);
//
//var_dump($id);

//$cat = R::dispense('category');
//$cat->title = 'Категория 600';
//$cat->id = 5;
//R::store($cat);

//$cat = R::load('category', 4);
//R::trash($cat);

//R::wipe('category');

$cats = R::findAll('category', 'title LIKE ?', ['%ко%']);
echo '<pre>';
print_r($cats);