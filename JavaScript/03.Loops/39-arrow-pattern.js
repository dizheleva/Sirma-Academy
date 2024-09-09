function buildTopCenter(n) {
    let row = '';
    for (let r = 1; r < n; r++) {
        row = '';

        for (let c = 1; c <= n - 1 - r; c++) {
            row += ' ';
        }

        for (let c = n - 1; c < n - 1 + r; c++) {

            row += '* ';
        }

        console.log(row);
    }
    
    for (let r = n; r < 2 * n - 1; r++) {
        row = '';
        let spaceLength;
        let starLength;
        if (n % 2 === 0) {
            spaceLength = (n - 2) / 2;
            starLength = n - 1;
        } else {
            spaceLength = (n - 1) / 2;
            starLength = n - 2;
        }

        for (let c = 0; c < starLength; c++) {

            while (row.length < spaceLength) {
                row += ' ';
            }
            row += '*';
        }

        console.log(row);
    }
}

buildTopCenter(7);
buildTopCenter(4);
buildTopCenter(6);