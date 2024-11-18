function solve() {
    function partialSum(num) {
        return (a, b, c) => a + b + c + num;
    }
    
    const addFive = partialSum(5);
    console.log(addFive(1, 2, 3)); // Output: 11
}

solve();