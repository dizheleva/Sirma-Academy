function solve(bottom, top, magicNumber) {
    let rezult;
    let counter = 0;
    let isCombination = false;
    for (let i = bottom; i <= top; i++) {        
        for (let j = bottom; j <= top; j++) {            
            isCombination = i + j === magicNumber;
            counter++;
            if (isCombination) {
                rezult = `Combination ${counter} - (${i} + ${j} = ${magicNumber})`;
                break;
            } else {
                rezult = `${counter} combinations - neither equals ${magicNumber}`;
            }            
        }

        if (isCombination) {
            break;
        }        
    }
    console.log(rezult);
}

solve(1, 10, 5);
solve(23, 24, 20);
solve(1, 2, 3);