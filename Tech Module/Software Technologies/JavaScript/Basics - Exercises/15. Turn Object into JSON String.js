function solve(input) {
    let result = {};
    for(let line of input) {
        let [key, value] = line.split(' -> ');
        if(!isNaN(value)) {
            value = Number(value);
        }
        result[key] =  value;
    }
    console.log(JSON.stringify(result));
}