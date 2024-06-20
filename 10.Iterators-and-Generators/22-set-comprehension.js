function solveDouble(numbers) {
    const generator = function* (numbers) {
        for (const number of numbers) {
            yield number * 2;
        }
    }

    let result = [];
    for (const value of generator(numbers)) {
        result.push(value);;
    }

    console.log(result.join(', '));
}

solveDouble([1, 2, 3, 4, 5]);

function solveABC(letters) {
    const generator = function* (letters) {
        for (const letter of letters) {
            yield letter.toUpperCase();
        }
    }

    let result = [];
    for (const value of generator(letters)) {
        result.push(value);;
    }

    console.log(result.join(', '));
}

solveABC(['a', 'b', 'c']);

function solveMinusFour(numbers) {
    const generator = function* (numbers) {
        for (const number of numbers) {
            yield number - 4;
        }
    }

    let result = [];
    for (const value of generator(numbers)) {
        result.push(value);;
    }

    console.log(result.join(', '));
}

solveMinusFour([5, 6, 7, 8, 9]);