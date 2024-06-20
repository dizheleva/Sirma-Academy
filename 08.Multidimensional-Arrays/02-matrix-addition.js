function solve(matrixA, matrixB) {
    let matrixC = [];

    for (let i = 0; i < matrixA.length; i++) {
        matrixC[i] = [];

        for (let j = 0; j < matrixA[i].length; j++) {
            matrixC[i][j] = matrixA[i][j] + matrixB[i][j];
        }
    }

    for (const row of matrixC) {
        console.log(row.join(' '));
    }
}

solve(
    [
        [1, 2],
        [3, 4]
    ],
    [
        [2, 2],
        [2, 2]
    ]
);
solve(
    [
        [1, 2, 3],
        [4, 3, 1]
    ],
    [
        [1, 2, 3],
        [4, 2, 2]
    ]
);