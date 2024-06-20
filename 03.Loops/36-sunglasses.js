function build(n) {
    let symbol;
    let row;

    for (let r = 1; r <= n; r++) {
        row = '';

        for (let c = 1; c <= n * 5; c++) {
            if (r === 1 && c <= n * 2 || r === 1 && c > n * 3
                || c === 1 || c === n * 2 || c === n * 3 + 1 || c === n * 5
                || r === n && c <= n * 2 || r === n && c > n * 3) {
                symbol = '*';
            } else if (c > n * 2 && c <= n * 3) {
                if (n % 2 === 0) {
                    if (r === n / 2) {
                        symbol = '|';
                    } else {
                        symbol = ' ';
                    }
                } else {
                    if (r === (n + 1) / 2) {
                        symbol = '|';
                    } else {
                        symbol = ' ';
                    }
                }
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