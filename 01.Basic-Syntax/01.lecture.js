
// variables

let firstName = "Pesho";
console.log(firstName);

let variableNaming = "camelCase";
// kebab-case

firstName = "Gosho";
console.log(firstName);

let pi = 3.14;
console.log(pi);

let age = 23;
console.log(age);

let isMale = true;
console.log(isMale);

let unknown;
console.log(unknown);
// unknown = undefined

// functions with params
function hello(firstName) {
    console.log("Hello, " + firstName);
}

hello("Pesho");
hello("Gosho");

// printing numbers

function solution() {
    let num = 100;
    console.log(num);
    let pi = 3.14;
    console.log(pi);
}

solution();

// Math. operations

console.log(10 + 2);
console.log(10 - 2);
console.log(10 * 2);
console.log(10 / 2);

let sum = 10 + 20;
console.log(sum);

function solve(a, b) {
    let sum = a + b;
    let difference = a - b;
    let product = a * b;
    let fraction = a / b;

    console.log(sum);
    console.log(difference);
    console.log(product);
    console.log(fraction);
}

solve(10, 2);

// concatenation
console.log("Hello, " + "Pesho");

console.log(10 + "10"); // 1010 (string)
console.log(10 - "10"); // 0 (number)

console.log(Math.ceil(3.14));
console.log(Math.floor(3.14));

let number = 3.14;
console.log(number.toFixed(1)); // = 3.1

// square area calculation

function calculateArea(side) {
    let area = side * side;

    console.log(area);
    
}

calculateArea(4);