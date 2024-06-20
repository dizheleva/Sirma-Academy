function aPattern(size) {
    let matrix = [];
    let count = 1;

    for (let col = 0; col < size; col++) {
        for (let row = 0; row < size; row++) {
            if (!matrix[row]) {
                matrix[row] = [];
            }

            matrix[row][col] = count++;
        }
    }

    return matrix;
}

function bPattern(size) {
    let matrix = [];
    let count = 1;

    for (let col = 0; col < size; col++) {
        for (let i = 0; i < size; i++) {
            if (!matrix[i]) {
                matrix[i] = [];
            }

            let row = i;
            if (col % 2 !== 0) {
                row = size - 1 - i;
            }

            matrix[row][col] = count++;
        }
    }

    return matrix;
}

function solve(size, pattern) {
    let matrix;

    if (pattern === 'A') {
        matrix = aPattern(size);
    } else {
        matrix = bPattern(size);
    }

    for (const row of matrix) {
        console.log(row.join(' '));
    }
}

solve(3, 'A');
solve(3, 'B');