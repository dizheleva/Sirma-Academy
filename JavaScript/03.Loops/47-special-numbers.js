function genetareSpecialNumbers(n) {
    for (let i = 1111; i <= 9999; i++) {

        let isSpecial = true;

        let currentNumber = i;
        while (currentNumber >= 1) {
            let divider = currentNumber % 10;
            isSpecial = n % divider === 0;

            if (!isSpecial) {
                break;
            }

            currentNumber = Math.trunc(currentNumber / 10);
        }

        if (isSpecial) {
            console.log(i);
        }
    }
}

genetareSpecialNumbers(3);