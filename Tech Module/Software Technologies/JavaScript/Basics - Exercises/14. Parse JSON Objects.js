function solve(input) {
        let personArr = input[0].map(JSON.parse);
        for(let p of personArr) {
            console.log(`Name: ${p.name}`);
            console.log(`Age: ${p.age}`);
            console.log(`Date: ${p.date}`);
        }
}