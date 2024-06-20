function* generateStack(stringInput) {
    for (let i = 0; i < stringInput.length; i++) {
        yield stringInput.charCodeAt(i);
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

solve('ab');
solve('cd');
solve('ef');