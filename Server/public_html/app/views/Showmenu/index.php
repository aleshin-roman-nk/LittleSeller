<div class = "panel-group">
    <a class ="btn btn-group btn-success" href = "/showmenu/chdt/?cmd=prev&date=<?= $shiftmenu->getName();?>">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    </a>
    
    <a class ="btn btn-group btn-default" href = "/showmenu/chdt/?cmd=now&date=<?= $shiftmenu->getName();?>"><h4><?= $shiftmenu->toStr(); ?></h4></a>
    
    <a class ="btn btn-group btn-success" href = "/showmenu/chdt/?cmd=next&date=<?= $shiftmenu->getName();?>">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    </a>
</div>


<div class="panel">

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

            <?php if (!empty($showitems)): ?>
                <?php $c = 1; ?>
                <?php foreach ($showitems as $cat => $items): ?>
            <tr>
                <td colspan="4"><b><?= $cat; ?></b></td>
            </tr>
            
            
                <?php foreach ($items as $item): ?>
                    <tr>
                        <th scope="row"><?= $c++; ?></th>
                        <td><?= $item['name'] ?></td>
                        <td><?= \app\models\product::weight($item['wpinfo']); ?></td>
                        <td><?= \app\models\product::price($item['wpinfo']); ?></td>
                    </tr>    
                <?php endforeach; ?>
                <?php endforeach; ?>
            <?php endif; ?>

        </tbody>
    </table> 

</div>