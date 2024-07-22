const partialSum = (function (addition) {    
    return function (...args) {
        return args.reduce((acc, n) => {
            return acc + n;
        }, addition);
    };
});

const addFive = partialSum(5);
console.log(addFive(1, 2, 3)); // Output: 11