<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\controllers\admin;
use fw\core\base\View;
use app\models\User;


class UserController extends AppController{
    
    //public $layout = 'default';
    
    public function indexAction(){
        
        
        View::setMeta('Админка :: Главная', 'Описание админки', 'Ключевики админки');
        $test = 'Test value';
        $data = ['test', 2];
// способ 1        
//        $this->set([
//                'test' => $test,
//                'data' => $data,            
//        ]);

        // способ 2
        $this->set(compact('test', 'data'));
    }
    
    public function loginAction(){      
        
        // debug(password_hash('3216732167', PASSWORD_DEFAULT));


        if(!empty($_POST)){
            $user = new User();
            if(!$user->login(true)){
                $_SESSION['error'] = 'Логин/пароль введены неверно';
            }
            
            if(User::isAdmin()){
                redirect(ADMIN);
            }else{
                redirect('/admin');
            }
        }
        
        $this->layout = 'login';
    }
    
    public function logoutAction(){
        User::logout();
        redirect('/admin');
    }
    
}
