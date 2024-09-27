function solve(bottom, top, magicNumber) {
    let result;
    let counter = 0;
    
    for (let i = bottom; i <= top; i++) {     
        let isCombination = false;
       
        for (let j = bottom; j <= top; j++) {            
            isCombination = i + j === magicNumber;
            counter++;
            if (isCombination) {
                result = `Combination ${counter} - (${i} + ${j} = ${magicNumber})`;
                break;
            } else {
                result = `${counter} combinations - neither equals ${magicNumber}`;
            }            
        }

        if (isCombination) {
            break;
        }        
    }
    
    console.log(result);
}

solve(1, 10, 5);
solve(23, 24, 20);
solve(1, 2, 3);