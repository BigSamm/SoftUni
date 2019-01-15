function setValuesToIndexes(input) {
    let size = Number(input[0]);
    let result = new Array(size).fill(0);
    for(let i = 1; i < input.length; i++) {
        let arr = input[i].split(" - ");
        let index = arr[0];
        let value = arr[1];
        result[index] = value;
    }

    for(let i = 0; i < result.length; i++) {
        console.log(result[i]);
    }
}