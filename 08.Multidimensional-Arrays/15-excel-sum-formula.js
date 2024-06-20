function getCellIndexes(cell) {
    let colLetters = cell.slice(0, cell.search(/\d/));
    let rowIndex = Number(cell.replace(colLetters, ''));

    let colIndex = 0;

    for (let i = 0; i < colLetters.length; i++) {
        const letterValue = colLetters[colLetters.length - 1 - i].charCodeAt(0) - 'A'.charCodeAt(0) + 1;
        colIndex += letterValue + 25 * i * letterValue;
    }

    return [rowIndex - 1, colIndex - 1];
}

function solve(inputSheet, rangeData) {
    const sheet = [];
    inputSheet.forEach(line => sheet.push(line));

    const [startCell, endCell] = rangeData.split(':');

    const [startRow, startCol] = getCellIndexes(startCell);
    const [endRow, endCol] = getCellIndexes(endCell);

    let sum = 0;

    for (let row = 0; row < sheet.length; row++) {
        for (let col = 0; col < sheet.length; col++) {
            if (row >= startRow && col >= startCol && row <= endRow && col <= endCol) {
                sum += sheet[row][col];
            }
        }
    }

    console.log(sum);
}

solve(
    [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ],
    'A1:C2'
);
solve(
    [
        [0, 1, 0, 0],
        [0, 0, 0, 1],
        [1, 0, 0, 0],
        [0, 1, 0, 0]
    ],
    'A1:B4'
);
solve(
    [
        [0, 1, 0, 0],
        [0, 0, 0, 0],
        [1, 0, 0, 0],
        [0, 0, 0, 0]
    ],
    'A1:C4'
);