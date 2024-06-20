function solve(arr) {

    arr[Symbol.iterator] = function () {
        const values = Object.values(this);
        let currentIndex = -2;

        return {
            next() {
                return {
                    value: values[currentIndex += 2],
                    done: currentIndex >= values.length,
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

solve([1, 2, 3, 4]);
solve(['a', 'b', 'c', 'd']);
solve([5, 6, 7, 8, 9]);