function build(n) {
    let symbol;
    let row = '';
    for (let s = 0; s < n ; s++) {
        row += ' ';
    }
    row += ' | ';
    console.log(row);
    for (let r = 1; r <= n; r++) {
        row = '';

        for (let c = 1; c <= r * 2 + 1; c++) {
            if (row.length < n - r) {
                for (let s = 1; s <= n - r; s++) {
                    row += ' ';
                }
            }
            if (c === r + 1) {
                symbol = ' | ';
            } else {
                symbol = '*'
            }

            row += symbol;
        }

        console.log(row);
    }    
}

build(1);
build(2);
build(3);
build(4);