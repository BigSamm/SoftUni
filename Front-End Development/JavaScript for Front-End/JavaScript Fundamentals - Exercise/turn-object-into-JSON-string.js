function turnObjectIntoJSONstring(input) {
    for(let i=0; i<input.length; i++){
        let result = {};
        for(let line of input){
            let [key, value] = line.split(' -> ');
            if(!isNaN(value)) {
                value = Number(value);
            }
            result[key] =  value;
        }
        console.log(JSON.stringify(result));
    }
}