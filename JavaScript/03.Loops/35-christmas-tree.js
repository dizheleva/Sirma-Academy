function build(n) {
    let symbol;
    
    for (let r = 0; r <= n; r++) {
        let row = '';

        for (let c = 0; c < r * 2 + 1; c++) {
            while (row.length < n - r) {
                row += ' ';
            }

            symbol = c == r ? " | " : "*";
            row += symbol;
        }

        console.log(row);
    }    
}

build(1);
build(2);
build(3);
build(4);