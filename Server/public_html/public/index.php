<?php

$query = rtrim($_SERVER['QUERY_STRING'], '/');

use fw\core\Router;

define('DEBUG', 1);
define('WWW', __DIR__);
define('CORE', dirname(__DIR__).'/vendor/fw/core');
define('ROOT', dirname(__DIR__));
define('LIBS', dirname(__DIR__) . '/vendor/fw/libs');
define('APP', dirname(__DIR__).'/app');
define('CACHE', dirname(__DIR__).'/tmp/cache');
define('LAYOUT', 'default');
//define('LAYOUT', 'blog');
//define('ADMIN', 'http://canteenfw.loc/admin');
define('ADMIN', "http://{$_SERVER['SERVER_NAME']}/admin");

require '../vendor/fw/libs/functions.php';

require __DIR__ . '/../vendor/autoload.php';

new \fw\core\App;

Router::add('^page/(?P<action>[a-z-]+)/(?P<alias>[a-z-]+)$', ['controller' => 'Page']);
Router::add('^page/(?P<alias>[a-z-]+)$', ['controller' => 'Page', 'action' => 'view']);

// default
Router::add('^admin$', ['controller' => 'Main', 'action' => 'index', 'prefix' => 'admin']);
Router::add('^admin/?(?P<controller>[a-z-]+)/?(?P<action>[a-z-]+)?$', ['prefix' => 'admin']);

Router::add('^$', ['controller' => 'Showmenu', 'action' => 'index']);
//Router::add('^$', ['controller' => 'Main', 'action' => 'index']);
Router::add('^(?P<controller>[a-z-]+)/?(?P<action>[a-z-]+)?$');

Router::Dispatch($query);