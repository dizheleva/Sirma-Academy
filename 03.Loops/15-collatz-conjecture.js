function solve(n) {        
    let result = `${n}`;
    while (n > 1) {
        if (n % 2 === 0) {
            n /= 2;
        } else {
            n = n * 3 + 1;
        }
        result += ` ${n}`;
    }
    console.log(result);
}

solve(6);
solve(12);
solve(9);
solve(200);
solve(15);