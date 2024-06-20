function solve(n) {
    let reversed = '';

    while (n >= 1) {
        reversed += (n % 10);
        n = Math.floor(n / 10);
    }

    console.log(reversed);
}

solve(123);
solve(9876);
solve(505);
solve(10203);
solve(7);