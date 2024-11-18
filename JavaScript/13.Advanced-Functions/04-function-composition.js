function solve() {
    function double(n) { return n * 2; }
    function square(n) { return n * n; }

    function compose(first, second) { return (num) => second(first(num)); }

    const doubleThenSquare = compose(double, square);
    console.log(doubleThenSquare(3)); 
}

solve();