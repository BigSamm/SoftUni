function parseJSONobjects(input) {
    for(let i=0; i<input.length; i++){
        let person = JSON.parse(input[i]);
        console.log('Name: ' + person.name);
        console.log('Age: ' + person.age);
        console.log('Date: ' + person.date);
    }
}