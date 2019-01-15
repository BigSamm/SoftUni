<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php

function drawStartMidEnd(){
    for($i = 0; $i < 5; $i++) {
        echo "<button style='background-color: blue'>1</button>";
    }
    echo "<br/>";
}

drawStartMidEnd();

for($i = 0; $i < 3; $i++) {
    echo "<button style='background-color: blue'>1</button>";
    for($h = 1; $h < 5; $h++) {
        echo "<button>0</button>";
    }
    echo "<br/>";
}

drawStartMidEnd();

for($i = 0; $i < 3; $i++) {
    for($h = 1; $h < 5; $h++) {
        echo "<button>0</button>";
    }
    echo "<button style='background-color: blue'>1</button>";
    echo "<br/>";
}

drawStartMidEnd();
?>
</body>
</html>