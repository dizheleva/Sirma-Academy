function solve(arr, size) {

    arr[Symbol.iterator] = function () {
        let values = Object.values(this);
        let pages = [];
        const pagesCount = Math.ceil(values.length / size);
        for (let i = 1; i <= pagesCount; i++) {
            const content = values.splice(0, size);
            const page = {};
            page[`page ${i}`] = content;
            pages.push(page);
        }
        let index = 0;

        return {
            next() {
                return {
                    value: pages[index++],
                    done: index > pages.length,
                };
            }
        }
    }

    let result = [];

    for (const value of arr) {
        for (const key in value) {
            result.push(`${key}: ${value[key]}`);
        }
    }

    console.log(result.join(', '));
}

solve([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 3);
solve(['a', 'b', 'c', 'd', 'e', 'f'], 2);