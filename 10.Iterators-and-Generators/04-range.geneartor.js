function* createRange(start, end) {
    while (start <= end) {
        yield start++;
    }
}
const rangeGen = createRange(2, 6);
console.log(rangeGen.next().value);
console.log(rangeGen.next().value);