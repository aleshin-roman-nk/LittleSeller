
<?php
/* new fw\widgets\menu\Menu([
  'tpl' => WWW . '/menu_widget/select.php',
  //    'tpl' => __DIR__ . '/menu_tpl/select.php',
  'class' => 'my-menu',
  'container' => 'select',
  'table' => 'categories',
  'cache' => 60,
  ]); */
?>


<div class = "panel-group">
    <a class ="btn btn-group btn-success" href = "/main/prev/?cat=<?= $ctitle->id; ?>&date=<?= $shiftmenu->getName(); ?>">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    </a>
    
    <a class ="btn btn-group btn-default" href = "/main/index/?cat=<?= $ctitle->id; ?>"><h4><?= $shiftmenu->toStr(); ?></h4></a>
    
    <a class ="btn btn-group btn-success" href = "/main/next/?cat=<?= $ctitle->id; ?>&date=<?= $shiftmenu->getName(); ?>">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    </a>
</div>

<div class="panel-group">
    <div class="btn-group">

        <?php if (!empty($categs)): ?>
            <?php foreach ($categs as $c): ?>
                <a class="btn btn-default" href = "/main/index/?cat=<?= $c->id; ?>&date=<?= $shiftmenu->getName(); ?>"><?= $c->title; ?></a>
            <?php endforeach; ?>
        <?php endif; ?>        

    </div>
</div>

<div class="panel-title">
    <h2><?= $ctitle->title; ?></h2>
</div>


<div class="panel" id = "srcmenu">

    <table class="table table-striped table-bordered">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Наименование</th>
                <th scope="col">Вес</th>
                <th scope="col">Цена</th>
            </tr>
        </thead>    
        <tbody>    

            <?php if (!empty($products)): ?>
                <?php $c = 1; ?>
                <?php foreach ($products as $prod_item): ?>

                    <tr>
                        <th scope="row"><?= $c++; ?></th>
                        <td><?= $prod_item['name'] ?></td>
                        <td><?= \app\models\product::weight($prod_item['wpinfo']); ?></td>
                        <td><?= \app\models\product::price($prod_item['wpinfo']); ?></td>
                        <td><a href="/main/add/?product_id=<?= $prod_item['id']; ?>&cat=<?= $ctitle->id; ?>&date=<?= $shiftmenu->getName(); ?>" class="btn btn-success glyphicon-plus"></a></td>
                    </tr>    

                <?php endforeach; ?>
            <?php endif; ?>

        </tbody>
    </table> 

</div>    

<div class="panel">

    <table class="table table-striped  table-bordered">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Наименование</th>
                <th scope="col">Вес</th>
                <th scope="col">Цена</th>
            </tr>
        </thead>    
        <tbody>    


            <?php if (!empty($menu)): ?>
                <?php $c = 1; ?>
                <?php foreach ($menu as $menu_item): ?>

                    <tr>
                        <th scope="row"><?= $c++; ?></th>
                        <td><?= $menu_item['name'] ?></td>
                        <td><?= \app\models\product::weight($prod_item['wpinfo']); ?></td>
                        <td><?= \app\models\product::price($prod_item['wpinfo']); ?></td>
                        <td><a href="/main/del/?product_id=<?= $menu_item['id']; ?>&cat=<?= $ctitle->id; ?>&date=<?= $shiftmenu->getName(); ?>" class="btn btn-danger glyphicon-minus"></a></td>
                    </tr>    

                <?php endforeach; ?>
            <?php endif; ?>

        </tbody>
    </table> 

</div>

<!--<script src = "/js/test.js"></script>-->

<!--<script>
    $(function(){
        $('#send').click(function(){
            $.ajax({
                url:'/main/show',
                type: 'post',
                data: {'id' : 3},
                success: function(res){
                    $("#answer").html(res);
                },
                error: function(){
                    alert('Error!');
                }
            });
        });        
    });
</script>-->

<script>

</script>
