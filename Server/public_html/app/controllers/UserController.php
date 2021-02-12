<?php

namespace app\controllers;
use fw\core\base\View;
use app\models\User;
/**
 * Description of UserController
 *
 * @author alesh
 */
class UserController extends AppController{
    
    public function signupAction(){
        if(!empty($_POST)){
            $user = new User();
            $data = $_POST;
            $user->load($data);

            if(!$user->validate($data) || !$user->checkUnique()){
                $user->getErrors();
                
                $_SESSION['form_data'] = $data;
                
                redirect('/user/signup');
            }
            
            $user->attributes['password'] = password_hash($user->attributes['password'], PASSWORD_DEFAULT);
            
            if($user->save('user')){
                $_SESSION['success'] = 'Registration success';
            }else{
                $_SESSION['error'] = 'Registration error';
            }
            
            redirect();
        }
        View::setMeta('Регистрация');
    }
    
    public function loginAction(){
        
        if(!empty($_POST)){
            $user = new User();
            if($user->login()){
                $_SESSION['success'] = 'Authorization success';
            }else{
                $_SESSION['error'] = 'Invalid login or password';
            }
            redirect();
        }
        
        View::setMeta('Login');
    }
    
    public function logoutAction(){
        if($_SESSION['user']){
            unset ($_SESSION['user']);
            
        }
        redirect('/user/login');
    }
}
