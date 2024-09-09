function solve(input) {
    const matrix = [];
    input.forEach(line => matrix.push(line.split(' ').map(Number)));

    const subSize = 3;
    let submatrix = [];
    let submatrixSum = 0;

    for (let i = 0; i <= matrix.length - subSize; i++) {
        for (let j = 0; j <= matrix[i].length - subSize; j++) {
            const subRows = [];
            let currentSum = 0;
            
            for (let s = 0; s < subSize; s++) {

                const subrow = [];
                for (let q = 0; q < subSize; q++) {
                    subrow.push(matrix[i + s][j + q]);                    
                }

                currentSum += subrow.reduce((sum, num) => sum + num);
                subRows.push(subrow);                
            }

            if (currentSum >= submatrixSum) {
                submatrixSum = currentSum;
                submatrix = [];
                subRows.forEach(row => submatrix.push(row));
            }                      
        }
    }

    console.log(`Sum = ${submatrixSum}`);
    submatrix.forEach(row => console.log(row.join(' ')));
}

solve(
    [
        "1 5 5 2 4",
        "2 1 4 14 3",
        "3 7 11 2 8",
        "4 8 12 16 4"
    ]
);

solve(
    [
        "1 0 4 3 1 1",
        "1 3 1 3 0 4",
        "6 4 1 2 5 6",
        "2 2 1 5 4 1",
        "3 3 3 6 0 5"
    ]
);