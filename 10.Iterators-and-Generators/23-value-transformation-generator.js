function* generateTransformation(arr, func) {
    switch (func) {
        case 'x => x * 2':
            for (const element of arr) {
                yield element * 2
            }
            break;
        case 'x => x * x':
            for (const element of arr) {
                yield element * element
            }
            break;
        case 'word => word.length':
            for (const element of arr) {
                yield element.length
            }
            break;
    }
}

function solve(arr, func) {

    let result = [];
    const generator = generateTransformation(arr, func);

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve([1, 2, 3], 'x => x * 2');
solve(['apple', 'banana'], 'word => word.length');
solve([5, 6, 7], 'x => x * x');