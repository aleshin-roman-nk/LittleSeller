<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace fw\core\base;

/**
 * Description of View
 *
 * @author roman
 */
class View {
    
    public $route = [];
    
    public $view;
    
    public $layout;
    
    public $scripts = [];
    
    public static $meta = ['title' => '', 'desc' => '', 'keywords' => ''];

    
    public function getName(){
        return get_class($this);
    }

    public function __construct($route, $layout = '', $view = '') {
        $this->route = $route;
        if($layout === false){
            $this->layout = false;
        }else{
          $this->layout = $layout ?: LAYOUT;  
        }
        $this->view = $view;
    }
    
    public function render($vars){
        
        $this->route['prefix'] = str_replace('\\', '/', $this->route['prefix']);
        
        if(is_array($vars)) {extract($vars);}
        
        $file_view = APP . "/views/{$this->route['prefix']}{$this->route['controller']}/{$this->view}.php";
        
        ob_start();
        {
            if(is_file($file_view)){
                require $file_view;
            }else{
                if(false !== $this->layout)
                    throw new \Exception("View-file not found: {$file_view}");
            }            
        }
        $content = ob_get_clean();
        
        if(false !== $this->layout){
            $file_layout = APP . "/views/layouts/{$this->layout}.php";
           if(is_file($file_layout)){
               $content = $this->getScripts($content);
               $scripts = [];
               if (!empty($this->scripts[0])) {
                    $scripts = $this->scripts[0];
                }
                require $file_layout;
           }else{
               throw new \Exception("Layout-file not found: {$file_layout}");
           }           
        }
    }
    
    protected function getScripts($content){
        $pattern = "#<script.*?>.*?</script>#si";
        preg_match_all($pattern, $content, $this->scripts);
        if(!empty($this->scripts)){
            $content = preg_replace($pattern, '', $content);
        }
        return $content;
    }
    
    public static function getMeta(){
        echo '<title>' . self::$meta['title'] . '</title>
        <meta name = "descriprion" content = "' . self::$meta['desc'] .'">
        <meta name = "keywords" content = "' . self::$meta['keywords'] . '">';
    }
    
    public static function setMeta($title = '', $desc = '', $keywords = ''){
        self::$meta['title'] = $title;
        self::$meta['desc'] = $desc;
        self::$meta['keywords'] = $keywords;
    }
    
    public function getPart($file){
            $file = APP . "/views/{$file}.php";
           if(is_file($file)){
               require_once $file;
           }else{
               echo "File not found: {$file} :( ...";
           }        
    }
}
