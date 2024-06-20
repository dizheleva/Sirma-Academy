function solve(n) {
    let sum = 0;

    for (let i = 0; i <= n * 2; i++) {
        if (i % 2 === 0) {
            sum += i;
        }
    }
    
    console.log(sum);
}

solve(3);
solve(5);
solve(1);
solve(0);
solve(10);