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
        if($n == 1)
            echo "1";
        elseif($n == 2)
            echo "1 1";
        elseif ($n == 3)
            echo "1 1 2";
        else {
            $result[] = 1;
            $result[] = 1;
            $result[] = 2;
            for($i = 3; $i<= $n-1; $i++) {
                $result[$i] = $result[$i-1] + $result[$i-2] + $result[$i-3];
            }
            echo join(" ", $result);
        }
    }
    ?>
</body>
</html>