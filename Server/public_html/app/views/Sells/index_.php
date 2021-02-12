

<div class = "panel-group">
    <h3>Вручка за <?= $d ?>: <b><?= $coll->amount ?></b> руб</h3>

            <?php foreach ($coll->collection as $receipt): ?>    
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
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td><b><?= $receipt->amount; ?></b></td>
                </tr>



        </tbody>
    </table> 
    
    
            <?php endforeach; ?>
    <div>