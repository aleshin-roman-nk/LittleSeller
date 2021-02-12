<?php

namespace fw\core;

class ErrorHandler {

    public function __construct() {
        if(DEBUG){
            error_reporting(-1);
        }else{
            error_reporting(0);
        }

        set_error_handler([$this, 'errorHandler']);
        ob_start();
        register_shutdown_function([$this, 'fatalErrorHandler']);
        set_exception_handler([$this, 'exceptionHandler']);
    }
    
    // public function exceptionHandler(\Exception $ex){
    public function exceptionHandler(\Throwable $ex){
        
        $this->logErrors($ex->getMessage(), $ex->getFile(), $ex->getLine(), 'exceptionHandler');     
        $this->displayError('Исключение', $ex->getMessage(), $ex->getFile(), $ex->getLine(), $ex->getCode());
    }
    
    public function errorHandler($errno, $errstr, $errfile, $errline){
        
        $this->logErrors($errstr, $errfile, $errline, 'errorHandler');
        
        $this->displayError($errno, $errstr, $errfile, $errline);

        return true;
    }
    
    public function fatalErrorHandler(){
        
        $error = error_get_last();
        if(!empty($error) && $error['type'] & ( E_ERROR | E_PARSE | E_COMPILE_ERROR | E_CORE_ERROR)){
            
            $this->logErrors($error['message'], $error['file'], $error['line'], 'fatalErrorHandler');
            ob_end_clean();
            $this->displayError($error['type'], $error['message'], $error['file'], $error['line']);
        }else{
            ob_end_flush();
        }
        
        
    }
    
    protected function displayError($errno, $errstr, $errfile, $errline, $responce = 500){
        
        http_response_code($responce);
        
        if($responce == 404 && !DEBUG){
            require WWW . '/errors/404.html';
            die;
        }
        
        if(DEBUG){
            require WWW . '/errors/dev.php';
        }else{
            require WWW . '/errors/prod.php';
        }
        die;
    }
    
    protected function logErrors($msg = '', $file = '', $line = '', $who = ''){
        error_log("[{$who}] " . "[" . date('Y-m-d H:i:s'). "] Текст ошибки: {$msg} | Файл: {$file} | Строка: {$line}\n===================================\n", 3, ROOT . "/tmp/errors.log");        
    }
    
}
