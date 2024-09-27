function build(n) {
    let rows = n * 2 - 1;
    let symbol = '* ';

    for (let r = 1; r <= rows; r++) {
        let row = '';

        let colEnd;
        if (r <= n) {
            colEnd = r;
        } else {
            colEnd = rows - r + 1;
        }
        
        for (let c = 1; c <= colEnd; c++) {                
            row += symbol;
        }

        console.log(row.trim());        
    }
}

build(1);
build(2);
build(3);
build(4);