function buildRightCenter(n) {
    let bottomRowNumCount = 0;
    let currentNum = 1;
    let rowCount = 1;
    while (true) {
        let isOver = false;
        for (let i = 1; i <= rowCount; i++) {
            bottomRowNumCount++;

            if (currentNum === n) {
                isOver = true;
                break;
            }

            currentNum++;
        }

        if (isOver) {
            break;
        }

        rowCount++;
        bottomRowNumCount = 0;
    }

    let bottomSize = rowCount;
    if (bottomRowNumCount != 0 && bottomRowNumCount != rowCount) {
        bottomSize--;
    }
    
    let number = 0;
    let longestSize;
    for (let r = 1; number < n; r++) {
        let output = '';
       
        for (let s = 0; s < bottomSize - r; s++) {
            output += '  ';
        }

        for (let c = 0; c < r && number < n; c++) {

            if (r === rowCount && c === 0) {
                let numberSize = number.toString().length;
                let spaceCount = longestSize - bottomRowNumCount * (numberSize + 1)
                for (let s = 0; s < spaceCount; s++) {
                    output += ' ';
                }
            }
            
            number++;
            output += ' ' + number;
        }

        longestSize = output.length;
        console.log(output);
    }
    
}

buildRightCenter(7);
buildRightCenter(10);
buildRightCenter(12);

function buildTopCenter(n) {    
    let currentNum = 0;

    for (let r = 1; currentNum < n; r++) {
        let output = '';

        let numbers = n;
        let rowCount = 0;
        while (numbers > 0) {
            rowCount++;
            numbers -= rowCount;
        }

        for (let s = 0; s < rowCount - r; s++) {
            output += ' ';
        }

        for (let c = 0; c < r && currentNum < n; c++) {
            currentNum++;
            output += ' ' + currentNum;
        }

        console.log(output);
    }
}

buildTopCenter(7);
buildTopCenter(10);
buildTopCenter(12);