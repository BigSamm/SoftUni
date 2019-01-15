function AddOrRemoveElements(input) {
    let result = [];

    for(let i=0; i<input.length; i++){
        let commandArr = input[i].split(" ");
        let command = commandArr[0];
        let num = Number(commandArr[1]);

        if(command === "add"){
            result.push(num);
        }
        else if (command === "remove") {
            result.splice(num, 1);
        }
    }

    for(let element of result){
        console.log(element);
    }
}