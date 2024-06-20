function* generatePowerOfTwo() {
    let number = 2;
    while (true) {
        
        let isPrime = true;

        for (let i = 2; i < number; i++) {
            if (number % i == 0) {
                isPrime = false;
            }
        }

        if (isPrime) {
            yield number;
        }

        number++;
    }    
}

let result = [];
const generator = generatePowerOfTwo();

for (let i = 0; i < 15; i++) {
    result.push(generator.next().value);
}

console.log(result.join(', '));