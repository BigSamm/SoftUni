function positiveOrNegative(nums) {
    let num1 = Number(nums[0]);
    let num2 = Number(nums[1]);
    let num3 = Number(nums[2]);

    let count = 0;
    if(num1 < 0)
        count++;
    if(num2 < 0)
        count++;
    if(num3 < 0)
        count++;

    if(count % 2 == 0)
        return "Positive";
    else
        return "Negative";
}