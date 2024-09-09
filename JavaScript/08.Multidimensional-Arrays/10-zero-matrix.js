function solve(input) {
    const matrix = [];
    input.forEach(line => matrix.push(line.split(' ')));

    let outputMatrix = [];
    matrix.forEach(row => outputMatrix.push(row.map(Number)));

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[0].length; col++) {
            let current = Number(matrix[row][col]);

            if (current === 0) {
                outputMatrix[row].fill(0);
                outputMatrix.forEach(r => r[col] = 0);
            }
        }
    }

    outputMatrix.forEach(row => console.log(row.join(' ')));
}

solve(
    [
        "1 2 3",
        "4 0 6",
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