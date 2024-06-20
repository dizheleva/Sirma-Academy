function solve(input) {
    let sum = 0;
    
    for (let i = 0; i < input.length; i++) {
        const letterValue = input[input.length - 1 - i].charCodeAt(0) - 'A'.charCodeAt(0) + 1;
        sum += letterValue + 25 * i * letterValue;
    }

    console.log(sum);
}

solve('AB');
solve('A');
solve('C');
solve('CZ');
solve('MM');