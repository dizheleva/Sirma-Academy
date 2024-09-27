function buildTopCenter(n) {    
    for (let r = 1; r <= n; r++) {
        let row = '';

        for (let c = 1; c <= n; c++) {
            let symbol;

            if ((r == 1 || r == n) && (c == 1 || c == n)) {
                symbol = '+';
            } else if (c === 1 || c === n) {
                symbol = '|';
            } else {
                symbol = '-';
            }

            row += symbol;
        }

        console.log(row);
    }
}

buildTopCenter(3);
buildTopCenter(4);
buildTopCenter(5);
buildTopCenter(6);