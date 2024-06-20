function rowHasQueens(chessboard) {
    for (let row = 0; row < chessboard.length; row++) {
        let queens = 0;

        for (let col = 0; col < chessboard[0].length; col++) {
            if (chessboard[row][col] === 1) {
                queens++;
                if (queens > 1) {
                    return true;
                }
            }
        }
    }

    return false;
}

function columnHasQueens(chessboard) {
    for (let col = 0; col < chessboard[0].length; col++) {
        let queens = 0;

        for (let row = 0; row < chessboard.length; row++) {
            if (chessboard[row][col] === 1) {
                queens++;
                if (queens > 1) {
                    return true;
                }
            }
        }
    }

    return false;
}

function diagonalHasQueens(chessboard) {
    for (let row = 0; row < chessboard.length; row++) {
        for (let col = 0; col < chessboard[0].length; col++) {

            if (chessboard[row][col] === 1) {
                let queens = 1;

                for (let i = 0; i < chessboard.length - row - 1; i++) {
                    let leftDiagonal = chessboard[row + i + 1][col - i - 1];
                    let rightDiagonal = chessboard[row + i + 1][col + i + 1];

                    if (leftDiagonal === 1 || rightDiagonal === 1) {
                        queens++;
                        if (queens > 1) {
                            return true;
                        }
                    }
                }
            }
        }
    }

    return false;
}

function solve(input) {
    const chessboard = [];
    input.forEach(line => chessboard.push(line.split(' ').map(Number)));

    if (rowHasQueens(chessboard) || columnHasQueens(chessboard) || diagonalHasQueens(chessboard)) {
        console.log('Yes');
    } else {
        console.log('No');
    }
}

solve(
    [
        "0 1 0 0",
        "0 0 0 1",
        "1 0 0 0",
        "0 0 1 0"
    ]
);

solve(
    [
        "0 1 0 0",
        "0 0 0 1",
        "1 0 0 0",
        "0 1 0 0"
    ]
);

solve(
    [
        "0 1 0 0",
        "0 0 0 0",
        "1 0 0 0",
        "0 0 0 0"
    ]
);