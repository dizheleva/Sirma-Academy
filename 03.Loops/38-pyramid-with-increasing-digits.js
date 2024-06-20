function buildTopCenter(n) {
    for (let r = 1; r <= n; r++) {
        let row = '';
        for (let c = 1; c <= n - r; c++) {
            row += ' ';            
        }

        let rowCounter = r;
        for (c = n - r + 1; c <= n; c++) {
            row += rowCounter;
            rowCounter++;
        }
        
        rowCounter = 2 * r - 2;
        for (c = n + 1; c < n + r; c++) {
            row += rowCounter;
            rowCounter--;
        }

        console.log(row);
    }
}

buildTopCenter(5);
buildTopCenter(4);
buildTopCenter(3);