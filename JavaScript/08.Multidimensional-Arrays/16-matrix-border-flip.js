function solve(input) {
    const matrix = [];    
    input.forEach(line => matrix.push(line.split(' ').map(Number)));
    
    const outputMatrix = [];
    matrix.forEach(row => outputMatrix.push(Array(row.length).fill(0)));

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {

            if (row === 0 && col < matrix[row].length - 1) {

                outputMatrix[row][col + 1] = matrix[row][col];
            } else if (row === matrix.length - 1) {

                if (col === 0) {
                    outputMatrix[row - 1][col] = matrix[row][col];
                } else {
                    outputMatrix[row][col - 1] = matrix[row][col];
                }
            } else {
                
                if (col === 0) {
                    outputMatrix[row - 1][col] = matrix[row][col];
                } else if (col === matrix[row].length - 1) {
                    outputMatrix[row + 1][col] = matrix[row][col];
                } else {
                    outputMatrix[row][col] = matrix[row][col];
                }
            }
        }
    }

    outputMatrix.forEach(row => console.log(row.join(' ')));
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
        "0 1 0 0",
        "0 0 0 1",
        "1 0 0 0",
        "0 1 0 0"
    ]
);