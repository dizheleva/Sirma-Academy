function solve(a, b) {
    let isMatch = false;

    for (let number = a; number < b; number++) {
        let evenSum = 0;
        let oddSum = 0;

        let currentNumber = number;
        while (currentNumber >= 10) {
            evenSum += currentNumber % 10;
            oddSum += Math.trunc(currentNumber / 10) % 10;
            currentNumber = Math.trunc(currentNumber / 100);
        }

        if (evenSum === oddSum) {
            console.log(number);
            isMatch = true;
        }
    }

    if (!isMatch) {
        console.log('None');
    }

}

solve(100000, 100050);
solve(299900, 300000);
solve(100115, 100120);