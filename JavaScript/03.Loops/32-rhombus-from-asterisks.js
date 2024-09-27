function buildTopCenter(n) {
    let rows = n * 2 - 1;
    let symbol = '* ';
    for (let r = 0; r < rows; r++) {
        let row = '';

        let colEnd;
        if (r < n) {
            colEnd = r + 1;
        } else {
            colEnd = rows - r;
        }

        for (let c = 0; c < colEnd; c++) {
            let spacesCount = Math.abs(n - (r + 1));

            while (row.length < spacesCount) {
                row += ' ';
            }

            row += symbol;
        }

        console.log(row);
    }
}

buildTopCenter(1);
buildTopCenter(2);
buildTopCenter(3);
buildTopCenter(4);