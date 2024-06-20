function solve(input) {
    const matrix = [];

    for (const line of input) {
        matrix.push(line.trim().split(' ').map(Number));
    }

    let rowSums = [];
    for (const row of matrix) {
        rowSums.push(row.reduce((sum, num) => sum + num));
    }

    let colSums = [];
    for (let col = 0; col < matrix[0].length; col++) {
        let colSum = 0;

        for (let row = 0; row < matrix.length; row++) {
            colSum += matrix[row][col];
        }

        colSums.push(colSum);
    }

    console.log(`Row Sums: ${rowSums.join(', ')}`);
    console.log(`Column Sum: ${colSums.join(', ')}`);
}

solve(
    [
        "1 2",
        "3 4",
        "5 6"
    ]
);
solve(
    [
        "1 2 3",
        "4 5 6",
        "7 8 9"
    ]
);