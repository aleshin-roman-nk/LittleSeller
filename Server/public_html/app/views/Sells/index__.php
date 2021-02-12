

<div class = "panel-group">

    <div class="container">
        <div class="panel panel-default">
            <div class="panel-body">
                <h4>Дата : <?= $d ?></h4>
                <h4>Выручка : <b><?= $coll->amount ?></b> руб</h4>
            </div>
        </div>
    </div>

    <?php foreach ($coll->collection as $receipt): ?>

        <div class="container">

            <div class="panel panel-default">
                <div class="panel-body"><?= $receipt->date ?> <b><?= " / Итог : " . $receipt->amount . " руб"; ?></b>



                    <table class="table table-striped table-bordered">
                        <thead>
                            <tr>
                                <th scope="col">Наименование</th>
                                <th scope="col">Вес</th>
                                <th scope="col">Кол-во</th>
                                <th scope="col">Цена</th>
                            </tr>
                        </thead>    
                        <tbody>    

                            <?php foreach ($receipt->items as $receipt_item): ?>

                                <tr>
                                    <td><?= $receipt_item['name']; ?></td>
                                    <td><?= $receipt_item['weight']; ?></td>
                                    <td><?= $receipt_item['count']; ?></td>
                                    <td><?= $receipt_item['discprice']; ?></td>
                                </tr>    

                            <?php endforeach; ?>

    <!--                            <tr>
    <td></td>
    <td></td>
    <td></td>
    <td><b><//?= $receipt->amount; ?></b></td>
    </tr>-->



                        </tbody>
                    </table> 

                </div>
            </div>
        </div>




    <?php endforeach; ?>
</div>