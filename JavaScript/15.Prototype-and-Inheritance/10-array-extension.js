(function solve() {
    Array.prototype.first = function () {
        if (this.length === 0) {
            throw new Error('Out of range');
        }

        return this[0];
    }

    Array.prototype.skip = function (n) {
        if (this.length <= n) {
            throw new Error('Out of range');
        }

        let result = [];

        for (let i = n; i < this.length; i++) {
            result.push(this[i]);
        }

        return result;
    }

    Array.prototype.take = function (n) {
        if (this.length < n) {
            throw new Error('Out of range');
        }

        let result = [];

        for (let i = 0; i < n; i++) {
            result.push(this[i]);
        }

        return result;
    }

    Array.prototype.product = function () {
        if (this.length === 0) {
            throw new Error('Out of range');
        }

        let product = 1;

        for (let i = 0; i < this.length; i++) {
            product *= this[i];
        }

        return product;
    }

    Array.prototype.unique = function () {
        if (this.length === 0) {
            throw new Error('Out of range');
        }

        let result = [];

        for (let i = 0; i < this.length; i++) {
            let isUnique = true;

            for (let j = 0; j < i; j++) {
                if (this[j] === this[i]) {
                    isUnique = false;
                }
            }

            if (isUnique) {
                result.push(this[i]);
            }
        }

        return result;
    }
}());

const arr = [3, 1, 2, 3, 3, 3];
console.log(arr.first()); //3
console.log(arr.skip(3)); //[3,3,3]
console.log(arr.take(3)); //[3,1,2]
console.log(arr.product()); //162
console.log(arr.unique()); //[3,1,2]