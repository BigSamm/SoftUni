function printNumbersReversed(nums) {
    let result = [];
    for(i = 0; i < nums.length; i++)
        result[i] = Number(nums[i]);

    result.reverse();
    for(let i = 0; i < result.length; i++)
        console.log(result[i]);
}