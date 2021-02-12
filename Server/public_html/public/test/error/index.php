<?php

define('DEBUG', 0);

class NotFoundException extends Exception{
    public function __construct(string $message = "", int $code = 402) {
        parent::__construct($message, $code);
    }
}

class ErrorHandler{
    public function __construct() {
        if(DEBUG){
            error_reporting(-1);
        }else{
            error_reporting(0);
        }
        //AND $error['type'] & ( E_ERROR | E_PARSE | E_COMPILE_ERROR | E_CORE_ERROR)
        set_error_handler([$this, 'errorHandler']);
        ob_start();
        register_shutdown_function([$this, 'fatalErrorHandler']);
        set_exception_handler([$this, 'exceptionHandler']);
    }
    
    public function exceptionHandler(Exception $ex){
        
        error_log("[" . date('Y-m-d H:i:s'). "] Текст ошибки: {$ex->getMessage()} | Файл: {$ex->getFile()} | Строка: {$ex->getLine()}\n===================================\n", 3, __DIR__ . "/errors.log");        
        
        $this->displayError('Исключение', $ex->getMessage(), $ex->getFile(), $ex->getLine(), $ex->getCode());
    }
    
    public function errorHandler($errno, $errstr, $errfile, $errline){
        error_log("[" . date('Y-m-d H:i:s'). "] Текст ошибки: {$errstr} | Файл: {$errfile} | Строка: {$errline}\n===================================\n", 3, __DIR__ . "/errors.log");
        $this->displayError($errno, $errstr, $errfile, $errline);
        return true;
    }
    
    public function fatalErrorHandler(){
        $error = error_get_last();
        if(!empty($error) && $error['type'] & ( E_ERROR | E_PARSE | E_COMPILE_ERROR | E_CORE_ERROR)){
            
        error_log("[" . date('Y-m-d H:i:s'). "] Текст ошибки: {$error['message']} | Файл: {$error['file']} | Строка: {$error['line']}\n===================================\n", 3, __DIR__ . "/errors.log");
            
            ob_end_clean();
            $this->displayError($error['type'], $error['message'], $error['file'], $error['line']);
        }else{
            ob_end_flush();
        }
    }
    
    protected function displayError($errno, $errstr, $errfile, $errline, $responce = 500){
        
        http_response_code($responce);
        
        if(DEBUG){
            require 'views/dev.php';
        }else{
            require 'views/prod.php';
        }
        die;
    }
}


new ErrorHandler();

//echo $test;

//test();

//try{
//    if(empty($test)){
//        throw new Exception('Упс, исключение');
//    }
//} catch (Exception $ex) {
//    var_dump($ex);
//}

//throw new NotFoundException('Упс, исключение');

throw new Exception('Упс, исключение', 503);