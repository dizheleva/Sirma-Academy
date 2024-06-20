function solve(input) {
    const matrix = [];    
    input.forEach(line => matrix.push(line.split(' ').map(Number)));

    let sum = 0;

    /* for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[0].length; col++) {
            if (row === 0 || row === matrix.length - 1
                || row !== 0 && row !== matrix.length - 1 
                && col === 0 || col === matrix[0].length - 1) {                    
                sum += matrix[row][col];
            }
        }
    } */

    matrix.forEach((row, i, m) => {
        if (i === 0 || i === m.length - 1) {
            sum += row.reduce((s, n) => s + n);
        } else {
            sum += row[0];
            sum += row[row.length - 1];
        }
    });

    console.log(sum);
}

solve(
    [
        "1 2 3",
        "4 5 6",
        "7 8 9"
    ]
);

solve(
    [
        "1 2 3 0",
        "4 5 6 7",
        "0 8 9 1"
    ]
);