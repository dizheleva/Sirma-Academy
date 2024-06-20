function solve(matrix) {
    let matrixSum = 0;

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            matrixSum += matrix[i][j];
        }
    }

    let rowsCount = matrix.length;
    let columnsCount = matrix[0].length;

    console.log(rowsCount);
    console.log(columnsCount);
    console.log(matrixSum);
}

solve(
    [
        [7, 1, 3, 3, 2, 1],
        [1, 3, 9, 8, 5, 6],
        [4, 6, 7, 9, 1, 0]
    ]
);
solve(
    [
        [10, 11, 12, 13],
        [14, 15, 16, 17]
    ]
);