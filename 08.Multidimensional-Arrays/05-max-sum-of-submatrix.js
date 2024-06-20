function solve(input) {
    let matrix = [];
    for (let i = 0; i < input.length; i++) {
        matrix.push(input[i].split(' '));
    }

    let submatrix = [];
    let submatrixSum = 0;

    for (let i = 0; i < matrix.length - 1; i++) {
        for (let j = 0; j < matrix[i].length - 1; j++) {
            let a = Number(matrix[i][j]);
            let b = Number(matrix[i][j + 1]);
            let c = Number(matrix[i + 1][j]);
            let d = Number(matrix[i + 1][j + 1]);

            let currentSum = a + b + c + d;

            if (currentSum >= submatrixSum) {
                submatrixSum = currentSum;
                submatrix[0] = [a, b];
                submatrix[1] = [c, d];
            }
        }
    }

    console.log(submatrixSum);
    for (const row of submatrix) {
        console.log(row.join(' '));
    }
}

solve(
    [
        "7 1 3 3 2 1",
        "1 3 9 8 5 6",
        "4 6 7 9 1 0"
    ]
);
solve(
    [
        "10 11 12 13",
        "14 15 16 17"
    ]
);