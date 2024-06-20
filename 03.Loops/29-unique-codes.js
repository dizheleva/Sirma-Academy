function solve(firstLimit, secondLimit, thirdLimit) {
    for (let firstDigit = 1; firstDigit <= firstLimit; firstDigit++) {
        if (firstDigit % 2 === 0) {
            if (secondLimit >= 2 && secondLimit <= 7) {
                for (let secondDigit = 2; secondDigit <= secondLimit; secondDigit++) {
                    let isPrime = true;
                    for (let i = 2; i < secondDigit; i++) {
                        if (secondDigit % i === 0) {
                            isPrime = false;
                        }
                        
                    }                   
                    
                    if (isPrime) {
                        for (let thirdDigit = 1; thirdDigit <= thirdLimit; thirdDigit++) {
                            if (thirdDigit % 2 === 0) {
                                console.log(`${firstDigit}${secondDigit}${thirdDigit}`);
                            }
                        }
                    }
                }
            }
            
        }
    }
}

solve(3, 5, 5);
solve(6, 2, 6);