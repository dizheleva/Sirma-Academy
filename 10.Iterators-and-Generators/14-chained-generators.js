function solve(input) {
    function* genA(partOne) {
        for (const element of partOne) {
            yield element;
        }
    }

    function* genB(partTwo) {
        for (const element of partTwo) {
            yield element;
        }
    }

    function* genAB() {
        yield* genA(input[0]);
        yield* genB(input[1]);
    }

    let result = [];
    const generator = genAB();

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve([[1, 2], [3, 4]]);
solve([['a', 'b'], ['c', 'd']]);
solve([[5, 6], [7, 8]]);