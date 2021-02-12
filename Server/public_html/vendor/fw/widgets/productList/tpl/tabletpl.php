<table class="table table-striped table-dark">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Наименование</th>
      <th scope="col">Тип</th>
      <th scope="col">Вес</th>
      <th scope="col">Цена</th>
<!--      <th scope="col">Действие</th>-->
    </tr>
  </thead>    
  <tbody>    
    
      
    <?= $table_content ?>  
      
   <?php //if(!empty($menu)): ?>
   <?php //foreach ($menu as $menu_item): ?>
   
<!--    <tr>
      <th scope="row"><?=$menu_item['id']?></th>
      <td><?=$menu_item['name']?></td>
      <td><?=$menu_item['category']?></td>
      <td><?=$menu_item['weight']?></td>
      <td><?=$menu_item['price']?></td>
      <td><button type="button" class="btn btn-block btn-success" id = "<?= $menu_item['id'] ?>">+</button></td>
      <td><a href="/?product_id=<?=$menu_item['id']/* . h('&')*/;?>" class="btn btn-block btn-success">+</a></td>
    </tr>    -->
       
    <?php //endforeach;?>
    <?php //endif; ?>

  </tbody>
</table> 