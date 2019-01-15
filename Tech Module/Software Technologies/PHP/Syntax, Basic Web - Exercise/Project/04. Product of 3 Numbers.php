<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
    <?php
    if(isset($_GET["num1"]) && isset($_GET["num2"]) && isset($_GET["num3"])) {
        $n1 = floatval(htmlspecialchars($_GET["num1"]));
        $n2 = floatval(htmlspecialchars($_GET["num2"]));
        $n3 = floatval(htmlspecialchars($_GET["num3"]));
        $countNegatives = 0;
        if ($n1 < 0)
            $countNegatives++;
        if ($n2 < 0)
            $countNegatives++;
        if ($n3 < 0)
            $countNegatives++;
        if ($n1 == 0 || $n2 == 0 || $n3 == 0)
            echo "Positive";
        else if ($countNegatives % 2 == 0)
            echo "Positive";
        else
            echo "Negative";
    }
    ?>
</body>
</html>