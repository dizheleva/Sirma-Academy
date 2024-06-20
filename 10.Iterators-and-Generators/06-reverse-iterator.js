function solve(arr) {

    arr[Symbol.iterator] = function () {
        const values = Object.values(this).reverse();
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

    let result = [];
    
    for (const value of arr) {
        result.push(value);
    }
    
    console.log(result.join(', '));
}

solve([1, 2, 3]);
solve(['a', 'b', 'c']);
solve([5, 4, 3, 2, 1]);