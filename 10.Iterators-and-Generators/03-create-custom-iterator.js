class OddIterator {
    constructor(arr) {
        this.arr = arr;
    }

    [Symbol.iterator]() {
        let oddValues = this.arr.filter(number => number % 2 !== 0);
        let index = 0;

        return {
            next() {
                return {
                    value: oddValues[index++],
                    done: index > oddValues.length,
                };
            }
        }
    }

}

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
const oddValues = new OddIterator(arr);
for (const value of oddValues) {
    console.log(value);
}