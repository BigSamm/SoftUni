function solve(input) {
    let result = [];
    for(let line of input) {
        let arr = line.split(' ');
        if(arr.length === 1) {
            if(result[arr[0]] === undefined) {
                console.log("None");
            } else {
                let output = result[arr[0]].split(' ');
                output.map(e => console.log(e));
            }
        } else {
            let key = arr[0];
            let value = arr[1];
            if(result[key] === undefined) {
                result[key] = value;
            } else {
                result[key] += ` ${value}`;
            }
        }
    }
}