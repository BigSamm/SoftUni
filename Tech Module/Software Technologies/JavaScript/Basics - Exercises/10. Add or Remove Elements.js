function addOrRemoveEl(input) {
    let result = [];
    for(let line of input) {
        let arr = line.split(" ");
        let command = arr[0];
        let num = Number(arr[1]);

        if(command === "add") {
            result.push(num);
        } else if (command === "remove") {
            result.splice(num, 1);
        }
    }
    result.map(e => console.log(e));
}