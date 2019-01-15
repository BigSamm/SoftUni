function arrayManipulation(input) {
    let result = [];

    for(let i=0; i<input.length-1; i++){
        let commandArr = input[i].split(" ");
        let key = commandArr[0];
        let value = commandArr[1];

        if(result[key] == undefined){
            result[key] = value
        }
        else {
            result[key] = result[key] + " " + value;
        }
    }

    let printIndex = input[input.length - 1];
    if(result[printIndex] == undefined){
        console.log("None");
    }
    else{
        let printArr = result[printIndex].split(" ");
        for(let element of printArr)
            console.log(element);
    }
}