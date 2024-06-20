function* generateStack(elements) {
    for (let i = 1; i <= elements.length; i++) {
        for (let j = 0; j <= elements.length - i; j++) {

            let result = [];
            result.push(elements.slice(j, j + i));

            yield result.join(',');
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

solve([1, 2]);
solve(['a', 'b', 'c']);
solve([5, 6]);