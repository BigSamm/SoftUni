function arrayManipulation(input) {
    let result = [];

    for(let i=0; i<input.length - 1; i++){
        let commandArr = input[i].split(" ");
        let key = commandArr[0];
        let value = commandArr[1];
        result[key] = value;
    }

    let printIndex = input[input.length - 1];
    if(result[printIndex] == undefined)
        console.log("None");
    else
        console.log(result[printIndex]);
}