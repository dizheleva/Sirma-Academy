function* generatePowerOfTwo() {
    let number = 1;
    while (true) {        
        yield number;
        number *= 2;
    }    
}

let result = [];
const generator = generatePowerOfTwo();

for (let i = 0; i < 9; i++) {
    result.push(generator.next().value);
}

console.log(result.join(', '));