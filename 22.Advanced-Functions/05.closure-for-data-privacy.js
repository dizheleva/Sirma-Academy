function createPrivateCounter() {
    return {
        count: 0,
        getCount: function () {
            return this.count;
        },
        increment: function () {
            this.count++;
        }
    }
}

const counter = createPrivateCounter();
counter.increment();
console.log(counter.getCount()); // Output: 1