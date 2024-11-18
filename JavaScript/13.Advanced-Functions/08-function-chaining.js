function solve() {
    const stringManipulator = {
        value: "",        
        setValue(value) {
            this.value = value;
            return this;
        },
        toUpperCase() {
             return this.setValue(this.value.toUpperCase());
        },
        toLowerCase() {
            return this.setValue(this.value.toLowerCase());
        },
        print() {
            console.log(this.value);
            return this;
        }
    };
    
    stringManipulator.setValue("Hello")
    .toUpperCase()
    .print()
    .toLowerCase()
    .print();
}

solve();