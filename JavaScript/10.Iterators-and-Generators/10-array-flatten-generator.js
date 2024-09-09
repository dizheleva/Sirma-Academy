function* generateStack(nestedArr) {
    for (let i = 0; i < nestedArr.length; i++) {
        if (nestedArr[i].length > 0) {
            for (let j = 0; j < nestedArr[i].length; j++) {
                yield nestedArr[i][j];
            }
        } else {
            yield nestedArr[i];
        }

    }
}

function solve(input) {

    let result = [];
    const generator = generateStack(input);

    for (const value of generator) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve([[1, 2], [3, 4]]);
solve(['a', ['b', 'c'], ['d', 'e']]);
solve([[5, 6], 7, [8, 9]]);