class List {
    #listCollection = [];

    add(element) {
        this.#listCollection.push(element);
        this.#listCollection.sort((a, b) => a - b);
    }

    remove(index) {
        if (index < 0 || index >= this.#listCollection.length) {
            console.log('Incorrect index!');

            return;
        }

        this.#listCollection.splice(index, 1);
    }

    get(index) {
        if (index < 0 || index >= this.#listCollection.length) {
            console.log('Incorrect index!');

            return;
        }

        return this.#listCollection[index];
    }

    size() {
        return this.#listCollection.length;
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));