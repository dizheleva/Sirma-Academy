function buildTopCenter(n) {
    let rows = n * 2 - 1;
    let symbol = '* ';
    for (let r = 1; r <= rows; r++) {
        let row = '';

        if (r <= n) {
            for (let c = 1; c <= r; c++) {
                if (row.length < n - r) {
                    for (let s = 1; s <= n - r; s++) {
                        row += ' ';
                    }
                }
                
                row += symbol;
            }

            console.log(row);
        } else {
            for (let c = rows - r + 1; c >= 1; c--) {
                if (row.length < r - n) {
                    for (let s = r - n; s >= 1; s--) {
                        row += ' ';
                    }
                }

                row += symbol;
            }

            console.log(row);
        }
    }
}

buildTopCenter(1);
buildTopCenter(2);
buildTopCenter(3);
buildTopCenter(4);