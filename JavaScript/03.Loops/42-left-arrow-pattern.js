function build(n) {
    let row;

    for (let r = 1; r < n; r++) {
        row = '';

        for (let c = 1; c <= n - 1 - r; c++) {
            row += ' ';
        }

        for (let c = n - 1 - r; c < n - 1; c++) {
            row += '*';
        }

        console.log(row);
    }

    for (let r = 1; r <= n - 2; r++) {
        row = '';

        for (let c = 1; c <= r; c++) {
            row += ' ';
        }

        for (let c = r; c <= n - 2; c++) {
            row += '*';
        }

        console.log(row);
    }
}

build(5);
build(4);
build(10);