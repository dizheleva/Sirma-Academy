function getFactorial(number) {
    if (number === 0 || number === 1) {
        return 1;
    }

    for (let i = number - 1; i >= 1; i--) {
        number *= i;
    }

    return number;
}

function divideFactorials(first, second) {
    let firstFactorial = getFactorial(first);
    let secondFactorial = getFactorial(second);

    let result = firstFactorial / secondFactorial;
    console.log(result.toFixed(2));
}

divideFactorials(5, 2);
divideFactorials(6, 2);