function solve(input) {
    let allPersons = [];
    for(let line of input) {
        let arr = line.split(' -> ');
        let name = arr[0];
        let age = arr[1];
        let grade = arr[2];

        let person = {};
        person.Name = name;
        person.Age = age;
        person.Grade = grade;
        allPersons.push(person);
    }
    for(let p of allPersons) {
        console.log(`Name: ${p.Name}`);
        console.log(`Age: ${p.Age}`);
        console.log(`Grade: ${p.Grade}`);
    }
}