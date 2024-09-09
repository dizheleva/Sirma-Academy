function solve(n) {
    let factorial = 1;

    for (let i = 1; i <= n; i++) {
        factorial *= i;
    }
    
    console.log(factorial);
}

solve(5);
solve(3);
solve(0);
solve(1);
solve(10);