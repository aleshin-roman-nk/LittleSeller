<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\controllers\admin;

use fw\core\base\Controller;
use \app\models\User;

/**
 * Description of AppController
 *
 * @author alesh
 */
class AppController extends Controller{
    public $layout = 'admin';
    
    public function __construct($route) {
        parent::__construct($route);
        
        if(!User::isAdmin() && $route['action'] != 'login'){
            redirect(ADMIN . '/user/login');
        }
    }
}
