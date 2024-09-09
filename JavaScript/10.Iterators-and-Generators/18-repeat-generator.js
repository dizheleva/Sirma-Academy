function* generateRepetition(value, repeating) {
    for (let i = 0; i < repeating; i++) {
        yield value;
    }
}

function solve(value, repeating) {

    let result = [];
    const generator = generateRepetition(value, repeating);

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve(2, 3);
solve('a', 4);
solve(7, 2);