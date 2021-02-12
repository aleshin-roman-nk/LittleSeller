<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="/bootstrap/css/bootstrap.min.css">
    <link href="/css/main.css" rel="stylesheet">
    
    <?php \fw\core\base\View::getMeta();?>
    
  </head>
  <body>    
          
    <?php //$this->getPart('\inc\categs');?>      
        
    <?php if(isset($_SESSION['error'])): ;?>
      <div class ="alert alert-danger">
          <?= $_SESSION['error']; unset($_SESSION['error']); ?>
      </div>
    <?php endif; ?>

    <?php if(isset($_SESSION['success'])): ;?>
      <div class ="alert alert-success">
          <?= $_SESSION['success']; unset($_SESSION['success']); ?>
      </div>
    <?php endif; ?>

      
    <?php //if(false):?>  
    <?php if(isset($_SESSION['productadded'])): ?>
      <div class ="alert alert-success">
          <?= $_SESSION['productadded']; unset($_SESSION['productadded']); ?>
      </div>
    <?php endif; ?>
    <?php //endif; ?>

    <?=$content?>
      
      
            
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="/bootstrap/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
       
    <?php
        foreach ($scripts as $script){
            echo $script;
        }
    ?>
  </body>
</html>

