const obj = {
    a: 'apple',
    b: 'banana',
    c: 'cherry'    
};

obj[Symbol.iterator] = function() {
    let values = Object.values(this);
    let currentIndex = 0;

    return {
        next() {
            return {
                value: values[currentIndex++],
                done: currentIndex > values.length,
            };
        }
    }
}

// Using generator
/* const obj2 = {
    a: 'apple',
    b: 'banana',
    c: 'cherry',
    [Symbol.iterator]: function*() {
        for (const value of Object.values(this)) {
            yield value;
        }
    }
}; */

for (const value of obj) {
    console.log(value);
}