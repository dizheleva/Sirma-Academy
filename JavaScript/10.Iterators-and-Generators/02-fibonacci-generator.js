function* fibonacci() {
    let firstValue = 0;
    let nextValue = 1;
    
    yield nextValue;

    while (true) {
        const currentValue = firstValue + nextValue;
        firstValue = nextValue;
        nextValue = currentValue;
        yield currentValue;
    }
}

const fib = fibonacci();
console.log(fib.next().value); // 1
console.log(fib.next().value); // 1
console.log(fib.next().value); // 2