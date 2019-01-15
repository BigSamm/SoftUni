function setValuesToIndex(inputArr) {
    let n = Number(inputArr[0]);
    let result = [];
    for(let i=0; i<n; i++)
        result.push(0);

    for(let i=1; i<inputArr.length; i++){
        let input = inputArr[i].split(" - ");
        let index = Number(input[0]);
        let num = Number(input[1]);
        result[index] = num;
    }

    for(let element of result){
        console.log(element);
    }
}