function solve(arr) {

    arr[Symbol.iterator] = function () {
        let evenValues = Object.values(this).filter(number => number % 2 == 0);
        let index = 0;

        return {
            next() {
                return {
                    value: evenValues[index++],
                    done: index > evenValues.length,
                };
            }
        }
    }

    let result = [];

    for (const value of arr) {
        result.push(value);
    }

    console.log(result.join(', '));
}

solve([1, 2, 3, 4, 5]);