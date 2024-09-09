function buildTopCenter(n) {
    let currentNum = 1;
    let line = 1;
    while (true) {
        let output = ``;
        let isOver = false;
        for (let i = 1; i <= line; i++) {   
            output += currentNum + ` `;
            if (currentNum === n) {
                isOver = true;
                break;
            }                    
            currentNum++;
        }
        console.log(output.trim());
        line++;
        if (isOver) {
            break;
        }
    }    
}

buildTopCenter(7);
buildTopCenter(10);
buildTopCenter(12);