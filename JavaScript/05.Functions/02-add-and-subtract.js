function getResult(first, second, third) {
    let output = subtract(sum(first, second), third);
    console.log(output);
}

function sum(a, b) {
    return a + b;
}

function subtract(a, b) {
    return a - b;
}

getResult(23, 6, 10);
getResult(1, 17, 30);
getResult(42, 58, 100);