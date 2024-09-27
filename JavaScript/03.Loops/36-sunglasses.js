function build(n) {
    for (let r = 1; r <= n; r++) {
        let row = '';

        for (let c = 1; c <= n * 5; c++) {
            let symbol;

            if (((r === 1 || r === n) && (c <= n * 2 || c > n * 3))
                || c === 1 || c === n * 2 || c === n * 3 + 1 || c === n * 5) {
                symbol = '*';
            } else if (c > n * 2 && c <= n * 3) {
                symbol = r == Math.ceil(n / 2) ? '|' : ' ';
            } else {
                symbol = '/';
            }

            row += symbol;
        }

        console.log(row);
    }
}

build(3);
build(4);
build(5);