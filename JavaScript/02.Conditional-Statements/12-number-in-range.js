function solve(number) {
    let isInRange = number >= -100 && number <= 100 && number != 0;

    let result;
    if (isInRange) {
        result = "Yes";
    } else {
        result = "No";
    }
    
    console.log(result);
}

solve(-25);
solve(0);
solve(25);