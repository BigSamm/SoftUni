function solve(input) {
    let result = [];
    for(let line of input) {
        let arr = line.split(' ');
        if(arr.length === 1) {
            if(result[arr[0]] === undefined) {
                console.log("None");
            } else {
                console.log(result[arr[0]]);
            }
        } else {
            let key = arr[0];
            let value = arr[1];
            result[key] = value;
        }
    }
}