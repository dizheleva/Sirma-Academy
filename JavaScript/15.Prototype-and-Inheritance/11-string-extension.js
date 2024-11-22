(function solve() {
    String.prototype.ensureStart = function (str) {
        if (this.substring(0, str.length) === str) {
            return true;
        }

        return false;
    }

    String.prototype.ensureEnd = function (str) {
        if (this.substring(this.length - str.length) === str) {
            return true;
        }

        return false;
    }

    String.prototype.isEmpty = function () {
        if (this.length === 0) {
            return true;
        }

        return false;
    }

    String.prototype.capitalize = function () {
        let result;
        result = this.substring(0, 1).toUpperCase() + this.substring(1);

        return result;
    }

    String.prototype.truncateWords = function (n) {
        const words = this.split(' ', n);
        let result = words.join(' ');

        if (this.length > result.length) {
            result += '...';
        }

        return result;
    }
}());

let str = 'the boy who lived';
let emptyStr = '';

console.log(str.ensureStart('the')); //true
console.log(str.ensureEnd('lived')); //true
console.log(str.isEmpty()); //false
console.log(emptyStr.isEmpty()); //true
console.log(str.capitalize()); // The boy who lived
console.log(str.truncateWords(2)); // the boy...
console.log(str.truncateWords(4)); // the boy who lived