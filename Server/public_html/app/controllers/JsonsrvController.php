<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace app\controllers;


/**
 * Description of JsonsrvController
 *
 * @author roman
 */
class JsonsrvController extends AppController{
    
    public $layout = false;


    public function indexAction(){
        // создать модель-маршрутизатор json-запросов который смотрит get и по нему выполняет действия и возвращает ответ

        $api = new \app\models\CommandAPI\requestapi();        
        echo $api->go();
    }
}
