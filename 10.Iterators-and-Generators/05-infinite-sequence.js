class SequenceGenerator {
    number = 1;

    *[Symbol.iterator]() {
        while (true) {
            yield this.number++;
        }
    }

    next() {
        return this[Symbol.iterator]().next().value;
    }
}

let seqGen = new SequenceGenerator();
console.log(seqGen.next());
console.log(seqGen.next());
console.log(seqGen.next());
console.log(seqGen.next());