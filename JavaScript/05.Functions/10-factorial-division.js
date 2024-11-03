function getFactorial(number) {
    let output = 1;
    if (number === 0) {
        output = getFactorial(number + 1);
    }

    for (let i = 1; i <= number; i++) {
        output *= i;
    }

    return output;
}

function divideFactorials(first, second) {
    let firstFactorial = getFactorial(first);
    let secondFactorial = getFactorial(second);

    let result = firstFactorial / secondFactorial;
    console.log(result.toFixed(2));
}

divideFactorials(5, 2);
divideFactorials(6, 2);