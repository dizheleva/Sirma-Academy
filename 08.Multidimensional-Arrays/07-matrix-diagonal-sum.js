function solve(input) {
    let matrix = [];

    for (const line of input) {
        matrix.push(line.split(' '));
    }

    let sum = 0;

    for (let i = 0; i < matrix.length; i++) {
        sum += Number(matrix[i][i]);
        sum += Number(matrix[matrix.length - 1 - i][i]);
    }

    console.log(sum);
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
        "10 11",
        "14 15"
    ]
);