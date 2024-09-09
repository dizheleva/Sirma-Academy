function build(n) {
    let rows = n * 2 - 1;
    let symbol = '* ';
    for (let r = 1; r <= rows; r++) {
        let row = '';

        if (r <= n) {
            for (let c = 1; c <= r; c++) {                
                row += symbol;
            }
            console.log(row.trim());
        } else {
            for (let c = rows - r + 1; c >= 1; c--) {
                row += symbol;                
            }
            console.log(row.trim());
        }
        
    }
}

build(1);
build(2);
build(3);
build(4);