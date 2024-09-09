function solve(arr) {

    arr[Symbol.iterator] = function () {
        let queue = Object.values(this);
        let index = 0;

        return {
            next() {
                return {
                    value: queue[index++],
                    done: index > queue.length,
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

solve([1, 2, 3]);
solve(['a', 'b', 'c']);
solve([5, 6, 7]);