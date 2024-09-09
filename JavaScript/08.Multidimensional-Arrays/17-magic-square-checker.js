function solve(input) {
    const matrix = [];
    input.forEach(line => matrix.push(line.split(' ').map(Number)));

    const firstSum = matrix[0].reduce((s, n) => s + n);
    let output = 'True';

    for (const row of matrix) {
        const currentSum = row.reduce((s, n) => s + n);
        if (currentSum !== firstSum) {
            output = 'False';
        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let currentSum = 0;
        matrix.forEach(row => currentSum += row[col]);;
        if (currentSum !== firstSum) {
            output = 'False';
        }
    }

    let firstDiagonalSum = 0;
    let secondDiagonalSum = 0;
   
    for (let i = 0; i < matrix.length; i++) {
        firstDiagonalSum += matrix[i][i];
        secondDiagonalSum += matrix[matrix.length - 1 - i][i];
    }

    if (firstDiagonalSum !== firstSum || secondDiagonalSum !== firstSum) {
        output = 'False';
    }

    console.log(output);
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
        "1 0 0 0",
        "0 0 0 1",
        "0 1 0 0",
        "0 0 1 0"
    ]
);

solve(
    [
        "8 1 6",
        "3 5 7",
        "4 9 2"
    ]
);