function build(n, m) {
    for (let r = 0; r < n; r++) {
        let row = '';

        for (let c = 0; c < m; c++) {
            let symbol;
            let isBorderRow = r === 0 || r === n - 1;

            if (isBorderRow) {
                symbol = '*';
            } else if (c === 0 || c === m - 1) {
                symbol = '*';
            } else {
                symbol = ' ';
            }

            row += symbol;
        }

        console.log(row);
    }
}

build(4, 6);
build(2, 2);
build(3, 4);