function* generateTransformation(arr, repeating) {
    const result = [];

    for (let i = 0; i < repeating; i++) {
        arr.forEach(element => result.push(element));
    }

    yield result;
}

function solve(arr, repeating) {

    let result = [];
    const generator = generateTransformation(arr, repeating);

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve([1, 2, 3], 2);
solve(['a', 'b'], 3);
solve([5, 6], 2);