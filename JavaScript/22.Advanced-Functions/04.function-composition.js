function double(num) {
    return num * 2;
}

function square(num) {
    return num * num;
}

function compose(...funcs) {
    return function (arg) {
        return funcs.reduce((accum, fn) => {
            return fn(accum);
        }, arg);
    };
}

const doubleThenSquare = compose(double, square);
console.log(doubleThenSquare(3)); // Output: 36