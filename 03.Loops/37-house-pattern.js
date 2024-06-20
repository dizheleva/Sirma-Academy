function build(n) {
    let row = '';
    let rows;
    
    let isEven = false;
    if (n % 2 === 0) {
        rows = n / 2;
        isEven = true;
    } else {
        rows = (n + 1) / 2;
    }

    for (let r = 1; r <= rows; r++) {
        row = '';

        let width;
        if (isEven) {
            width = r * 2;
        } else {
            width = r * 2 - 1;
        }

        for (let c = 1; c <= width; c++) {
            if (row.length < n - r) {
                for (let s = 1; s <= n - r; s++) {
                    row += ' ';
                }
            }

            row += '*';
        }

        console.log(row);
    }
    
    for (let i = 0; i < 2; i++) {
        row = '';

        for (let s = 0; s < n; s++) {
            if (s === 0 || s === n - 1) {
                row += '*';
            } else {
                row += ' ';
            }
        }     

        console.log(row);
    }        
}

build(7);
build(4);
build(3);
build(6);