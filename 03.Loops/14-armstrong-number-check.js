function solve(n) {
    let textNumber = n.toString();
    let digitsCount = textNumber.length;
    let result = 0;

    for (let i = 0; i < digitsCount; i++) {        
        result = result + Math.pow(textNumber[i], digitsCount);  
    }
    
    let isArmstrong = result === n;
    console.log(isArmstrong);
}

solve(153);
solve(370);
solve(123);
solve(407);
solve(1634);