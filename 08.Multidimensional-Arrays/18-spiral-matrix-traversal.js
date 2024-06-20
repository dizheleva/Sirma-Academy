function solve(input) {
    const matrix = [];
    input.forEach(line => matrix.push(line.split(' ').map(Number)));

    let topIndex = 0;
    let bottomIndex = matrix.length - 1;
    let leftIndex = 0;
    let rightIndex = matrix[0].length - 1;

    let result = [];

    while (topIndex <= bottomIndex && leftIndex <= rightIndex) {
        for (let i = leftIndex; i <= rightIndex; i++) {
            result.push(matrix[topIndex][i]);
        }
        topIndex++;

        for (let i = topIndex; i <= bottomIndex; i++) {
            result.push(matrix[i][rightIndex]);
        }
        rightIndex--;

        for (let i = rightIndex; i >= leftIndex; i--) {
            result.push(matrix[bottomIndex][i]);
        }
        bottomIndex--;

        for (let i = bottomIndex; i >= topIndex; i--) {
            result.push(matrix[i][leftIndex]);
        }
        leftIndex++;
    }

    console.log(result.join(' '));
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
        "1 2 3 4",
        "5 6 7 8",
        "9 10 11 12",
        "13 14 15 16"
    ]
);

solve(
    [
        "1 2",
        "3 4"
    ]
);