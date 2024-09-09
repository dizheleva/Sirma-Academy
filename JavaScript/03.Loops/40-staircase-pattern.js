function buildTopCenter(n) {
    let row = '';
    
    for (let r = 1; r <= n; r++) {
        let rowLength = row.length - 1 + r;
        let hashStart = rowLength - r;
        row = '';

        for (let c = 0; c < hashStart; c++) {
            row += ' ';
        }
        
        for (let c = hashStart - 1; c < rowLength - 1; c++) {
            row += '#';
        }

        console.log(row);
    }
}

buildTopCenter(5);
buildTopCenter(4);
buildTopCenter(2);