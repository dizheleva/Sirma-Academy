function* generateBinary(input) {
    for (let i = input.length - 1; i >= 0; i--) {
        yield input[i];
    }
}

function solve(input) {

    let result = [];
    const generator = generateBinary(input);

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve([1, 2, 3]);
solve(['a', 'b', 'c']);
solve([5, 6, 7]);