function solve(arr, indexes) {

    arr[Symbol.iterator] = function () {
        let slicedArr = Object.values(this).slice(indexes[0], indexes[1] + 1);
        let index = 0;

        return {
            next() {
                return {
                    value: slicedArr[index++],
                    done: index > slicedArr.length,
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

solve([1, 2, 3, 4, 5], [1, 3]);
solve(['apple', 'banana', 'cherry', 'date'], [0, 2]);
solve([5, 6, 7, 8, 9, 10], [4, 5]);