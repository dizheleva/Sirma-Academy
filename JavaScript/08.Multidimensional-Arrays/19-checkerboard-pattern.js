function solve(size) {
    const checkerboard = [];

    for (let row = 0; row < size; row++) {

        const rowPattern = [];
        for (let col = 0; col < size; col++) {

            if (row % 2 !== 0 && col % 2 === 0 || row % 2 === 0 && col % 2 !== 0) {
                rowPattern.push(1);
            } else {
                rowPattern.push(0);
            }
        }

        checkerboard.push(rowPattern);
    }

    checkerboard.forEach(row => console.log(row.join(' ')));
}

solve(3);
solve(4);