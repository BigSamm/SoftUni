function productOfThreeNums(input) {
    let nums = input.map(Number);
    let count = 0;
    let isZero = false;

    for(let i = 0; i < nums.length; i++) {
        if(nums[i] < 0) {
            count++;
        }
        if(nums[i] === 0) {
            isZero = true;
        }
    }

    if(count % 2 == 0 || isZero) {
        console.log("Positive");
    } else {
        console.log("Negative");
    }
}