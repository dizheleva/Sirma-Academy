function solve(n) {
    for (let num = 1; num <= 1000; num++) {
        if (num % 10 === n) {
            console.log(num);   
        }
        
    }
}

solve(6);
solve(8);