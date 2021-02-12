<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\models;
use fw\core\base\Model;
/**
 * Description of User
 *
 * @author alesh
 */
class User extends Model{
    
    public $attributes = [
        'login' => '',
        'password' => '',
        'email' => '',
        'name' => '',
    ];
    
    public $rules = [
      'required' => [
          'login',
          'password',
          'email',
          'name'
      ],
      'email' => [
          ['email'],
      ],
      'lengthMin' => [
          ['password', 6],
      ]
    ];
    
    public function checkUnique(){
        
        $user = \R::findOne('user', 'login = ? OR email = ? LIMIT 1', [
            $this->attributes['login'],
            $this->attributes['email'],
        ]);
        
        if($user){
            if($user->login == $this->attributes['login']){
                $this->errors['unique'][] = 'Login already exists';
            }
            
            if ($user->email == $this->attributes['email']) {
                $this->errors['unique'][] = 'Email already exists';
            }
            
            return false;
        }
        
        return true;
    }
    
    public function login($isAdmin = false){
        $login = !empty($_POST['login']) ? trim($_POST['login']) : null;
        $password = !empty($_POST['password']) ? trim($_POST['password']) : null;
        
        if($login && $password){
            
            if($isAdmin){
               $user = \R::findOne('user', "login = ? AND role = 'admin' LIMIT 1", [ $login]);
            }else{
                $user = \R::findOne('user', 'login = ? LIMIT 1', [ $login]);
            }
            
            if($user){
                if(password_verify($password, $user->password)){
                    
                    foreach ($user as $k => $v){
                        if($k != 'password') $_SESSION['user'][$k] = $v;
                    }
                    
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public static function logout(){
        if(isset($_SESSION['user'])){
            unset($_SESSION['user']);
        }
    }
    
    public static function isAdmin(){
        return (isset($_SESSION['user']) && $_SESSION['user']['role'] == 'admin');
    }
}
