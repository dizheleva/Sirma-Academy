function* generateBinary(decimal) {
    yield decimal.toString(2);
}

function solve(number) {

    let result = [];
    const generator = generateBinary(number);

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve(5);
solve(8);
solve(15);