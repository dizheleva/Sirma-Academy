function solve(n) {
    let sum = 0;
    let a = 0;
    let b = 1;    

    for (let i = 0; i <= n; i++) {
        sum += a;
        let step = a + b;
        a = b;
        b = step;
    }

    console.log(sum);
}

solve(3);
solve(5);
solve(1);
solve(0);
solve(10);