function storingObjects(input) {
    let result = [];

    for(let i=0; i<input.length; i++){
        let inputArr = input[i].split(" -> ");
        let name = inputArr[0];
        let age = inputArr[1];
        let grade = inputArr[2];

        let student = {};
        student.Name = name;
        student.Age = age;
        student.Grade = grade;

        result[i] = student;
    }

    for(let element of result) {
        console.log("Name: " + element.Name);
        console.log("Age: " + element.Age);
        console.log("Grade: " + element.Grade);
    }
}