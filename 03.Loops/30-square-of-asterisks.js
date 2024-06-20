function buildTopCenter(n) {
    for (let r = 0; r < n; r++) {
        let row = '';

        for (let c = 0; c < n; c++) {
            let symbol = '* ';
            row += symbol;
        }

        console.log(row.trim());
    }
}

buildTopCenter(2);
buildTopCenter(3);