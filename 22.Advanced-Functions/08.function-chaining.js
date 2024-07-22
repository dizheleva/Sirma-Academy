const stringManipulator = {
    value: '',
    setValue(newValue) {
        this.value = newValue;
        return this;
    },
    toLowerCase() {
        this.value = this.value.toLowerCase();
        return this;
    },
    toUpperCase() {
        this.value = this.value.toUpperCase();
        return this;
    },
    print() {
        console.log(this.value);
        return this;
    }
};

stringManipulator.setValue('Hello')
    .toUpperCase()
    .print()
    .toLowerCase()
    .print();
// HELLO
// hello