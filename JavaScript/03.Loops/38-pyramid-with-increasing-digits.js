function buildTopCenter(n) {
    for (let r = 1; r <= n; r++) {
        let row = '';

        let rowCounter = r;
        for (let c = n - r + 1; c < n + r; c++)
        {
            while (row.length < n - r + 1) {
                row += ' ';
            }

            row += rowCounter;
            rowCounter += c >= n ? -1 : 1;
        }

        console.log(row);
    }
}

buildTopCenter(5);
buildTopCenter(4);
buildTopCenter(3);