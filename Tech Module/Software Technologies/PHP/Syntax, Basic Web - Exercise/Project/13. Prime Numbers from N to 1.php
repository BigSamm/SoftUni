<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if(isset($_GET["num"])) {
        $n = intval($_GET["num"]);
        $result = array();
        for($i = $n; $i>=2; $i--) {
            $isPrime = true;
            for($h = $i - 1; $h>=2; $h--) {
                if($i % $h == 0)
                    $isPrime = false;
            }
            if($isPrime)
                $result[] = $i;
        }
        echo join(" ", $result);
    }
    ?>
</body>
</html>