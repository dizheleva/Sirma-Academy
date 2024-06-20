function solve(firstInput, secondInput) {
    let matrixA = [];
    let matrixB = [];
    let matrixC = [];

    for (let i = 0; i < firstInput.length; i++) {
        matrixA.push(firstInput[i].split(' '));
        matrixB.push(secondInput[i].split(' '));
    }

    for (let i = 0; i < matrixA.length; i++) {
        matrixC[i] = [];

        for (let j = 0; j < matrixA[i].length; j++) {
            if (matrixA[i][j] === matrixB[i][j]) {
                matrixC[i][j] = matrixA[i][j];
            } else {
                matrixC[i][j] = '*';
            }
        }
    }

    for (const row of matrixC) {
        console.log(row.join(' '));
    }
}

solve(
    [
        "a b c d",
        "a b c d",
        "a b c d"
    ],
    [
        "k b c k",
        "a b g d",
        "a k c d"
    ]
);
solve(
    [
        "1 2",
        "3 4",
        "5 6",
        "7 8",
        "9 1"
    ],
    [
        "0 2",
        "3 1",
        "1 6",
        "7 4",
        "1 1"
    ]
);