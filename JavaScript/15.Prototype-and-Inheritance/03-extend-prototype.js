function attachHuman(className) {
    const propertyName = 'species';
    const propertyValue = 'Human';

    className.prototype[propertyName] = propertyValue;
    className.prototype.toSpeciesString = function () { return `I am a ${this.species}. ${this.toString()}`; }
}

class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    toString() {
        return `Name: ${this.name}. Age: ${this.age}.`
    }
}

attachHuman(Person);

let someone = new Person('Someone', 47);
console.log(someone.toSpeciesString());