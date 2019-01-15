function printLines(input) {
    for(let line of input) {
        if(line != "Stop") {
            console.log(line);
        } else return;
    }
}