function build(n) {
    let symbol = '*';
    let row = '';

    for (let r = 1; r <= n; r++) {
        row = '';

        for (let c = 1; c <= r * 2 - 1; c++) {
            while (row.length < n - r) {
                row += ' ';
            }

            row += symbol;
        }

        console.log(row);
    }

    row = '';
    for (let s = 0; s < n - 1; s++) {
        row += ' ';
    }
    row += symbol;
    
    console.log(row);
}

build(6);
build(4);
build(3);