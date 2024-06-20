function solve(input) {
    const matrix = [];
    input.forEach(line => matrix.push(line.split(' ').map(Number)));

    const rotatedMatrix = [];
    for (let col = 0; col < matrix.length; col++) {
        const rotatedRow = [];

        for (let row = matrix.length - 1; row >= 0; row--) {
            rotatedRow.push(matrix[row][col]);
        }

        rotatedMatrix.push(rotatedRow);
    }

    rotatedMatrix.forEach(row => console.log(row.join(' ')));
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
        "0 1 2 3",
        "4 5 6 7",
        "8 9 10 11",
        "12 13 14 15"
    ]
);