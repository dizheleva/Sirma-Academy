const getFibonacci = (function () {
    let firstValue = 0;
    let nextValue = 1;
    return function () {
        let currentValue = nextValue;
        nextValue += firstValue;
        firstValue = currentValue;
        return currentValue;
    }
});

let fibonacci = getFibonacci();
console.log(fibonacci()); // 1
console.log(fibonacci()); // 1
console.log(fibonacci()); // 2
console.log(fibonacci()); // 3
console.log(fibonacci()); // 5
console.log(fibonacci()); // 8
console.log(fibonacci()); // 13
console.log(fibonacci()); // 21