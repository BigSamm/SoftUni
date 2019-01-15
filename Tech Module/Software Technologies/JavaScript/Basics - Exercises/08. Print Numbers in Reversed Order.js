function printNums(input) {
    let nums = input
        .map(Number)
        .reverse();
    for(let i = 0; i < nums.length; i++) {
        console.log(nums[i]);
    }
}