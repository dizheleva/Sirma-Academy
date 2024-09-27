function buildTopCenter(n) {
    let row = '';

    for (let r = 1; r <= n; r++) {
        let rowLength = row.length - 1 + r;
        let hashStart = rowLength - r;
        row = '';

        for (let c = 0; c < rowLength; c++) {
            row += c < hashStart ? ' ' : '#';
        }

        console.log(row);
    }
}

buildTopCenter(5);
buildTopCenter(4);
buildTopCenter(2);