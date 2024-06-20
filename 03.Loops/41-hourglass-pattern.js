function build(n) {
    let row = '';

    let topBottomLength;
    let rowsCount;

    if (n % 2 === 0) {
        topBottomLength = n + 2;
        rowsCount = n - 1;
    } else {
        topBottomLength = n + 2;
        rowsCount = n;
    }

    // print first row
    for (let i = 0; i < topBottomLength; i++) {
        row += '#';
    }
    console.log(row);

    //print body
    for (let r = 1; r <= rowsCount; r++) {
        row = '';

        for (let c = 1; c <= topBottomLength; c++) {
            let isTop = r <= rowsCount / 2 + 1;
            let hashOne = r + 1;;
            let hashTwo = topBottomLength - r;;
            if (!isTop && n % 2 === 0) {
                hashOne = r + 2;
                hashTwo = topBottomLength - r - 1;
            } 

            if (c === hashOne || c === hashTwo) {
                row += '#';
            } else {                
                row += ' ';
            }
        }
        
        console.log(row);
    }

    //print last row
    row = '';
    for (let i = 0; i < topBottomLength; i++) {
        row += '#';
    }
    console.log(row);
}

build(5);
build(8);
build(2);