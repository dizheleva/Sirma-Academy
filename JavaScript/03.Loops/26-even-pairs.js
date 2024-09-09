function solve(firstPairInput, secondPairInput, differenceFirstPair, differenceSecondPair) {
    for (let firstPair = firstPairInput; firstPair <= firstPairInput + differenceFirstPair; firstPair++) {
        let isFirstPrime = true;
        for (let i = 2; i < firstPair; i++) {
            if (firstPair % i === 0) {
                isFirstPrime = false;
            }
        }

        if (isFirstPrime) {
            for (let secondPair = secondPairInput; secondPair <= secondPairInput + differenceSecondPair; secondPair++) {              
                let isSecondPrime = true;            
                for (let i = 2; i < secondPair; i++) {
                    if (secondPair % i === 0) {
                        isSecondPrime = false;
                    }
                }
                      
                if (isSecondPrime) {  
                    console.log(`${firstPair}${secondPair}`);
                }
            }
        }        
    }
}

solve(10, 20, 5, 5);
solve(10, 30, 9, 6);