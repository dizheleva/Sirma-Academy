function solve(matrixA, matrixB) {
    let isEqual = true;

    if (matrixA.length != matrixB.length) {
        isEqual = false;
    }

    for (let i = 0; i < matrixA.length; i++) {
        if (matrixA[i].length !== matrixB[i].length || !isEqual) {
            isEqual = false;
            break;
        }

        for (let j = 0; j < matrixA[i].length; j++) {
            if (matrixA[i][j] !== matrixB[i][j]) {
                isEqual = false;
                break;
            }
        }
    }

    if (isEqual) {
        console.log('equal');
    } else {
        console.log('not equal');
    }
}

solve(
    [
        [1, 2, 3],
        [2, 1, 3]
    ],
    [
        [1, 2, 3],
        [2, 1, 3]
    ]
);
solve(
    [
        [1, 2, 3],
        [4, 5, 6]
    ],
    [
        [1, 3],
        [4, 5]
    ]
);