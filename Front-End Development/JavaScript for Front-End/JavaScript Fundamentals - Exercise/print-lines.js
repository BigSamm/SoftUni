function printLines(lines) {
    for(let i = 0; i < lines.length; i++) {
        let line = lines[i];
        if(line != "Stop")
            console.log(line);
        else
            break;
    }
}