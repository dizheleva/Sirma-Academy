class StringContainer {
    constructor(string, length) {
        this.innerString = string;
        this.innerLength = length;
    }

    increase(length) {
        this.innerLength += length;
    }

    decrease(length) {
        if (this.innerLength < length) {
            length = this.innerLength;
        }

        this.innerLength -= length;
    }

    toString() {
        let result = this.innerString.slice(0, this.innerLength);
        if (this.innerString.length > this.innerLength) {
            result += '...';
        }

        return result;
    }
}

let test = new StringContainer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); // Test