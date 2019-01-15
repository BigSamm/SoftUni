<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num1" />
        M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
	<ul>
        <?php
        if(isset($_GET["num1"]) && isset($_GET["num2"])) :
            $n1 = $_GET["num1"];
            $n2 = $_GET["num2"];
            for($i = 1; $i <= $n1; $i++) : ?>
                <li><?= "List $i"; ?>
                    <ul>
                        <?php for($h = 1; $h <= $n2; $h++) : ?>
                            <li><?= "Element $i.$h"; ?></li>
                        <?php endfor; ?>
                    </ul>
                </li>
            <?php endfor; ?>
        <?php endif; ?>
	</ul>
</body>
</html>