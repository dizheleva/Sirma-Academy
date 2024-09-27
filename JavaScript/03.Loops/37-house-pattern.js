function build(n) {
    let row = '';
    let rows = Math.round(n / 2);
        
    for (let r = 1; r <= rows; r++) {
        row = '';

        let width = n - 2 * (rows - r);
        for (let c = 1; c <= width; c++) {
            while (row.length < rows - r) {
                row += ' ';
            }

            row += '*';
        }

        console.log(row);
    }
    
    for (let i = 0; i < 2; i++) {
        row = '';

        for (let s = 0; s < n; s++) {
            row += s === 0 || s === n - 1 ? '*' : ' ';
        }     

        console.log(row);
    }        
}

build(7);
build(4);
build(3);
build(6);