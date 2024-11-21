function attachProperty(className) {
    const propertyValue = 'Human';

    className.prototype.species = propertyValue;
    className.prototype.toSpeciesString = function () { return `I am a ${this.species.toString()}`;}
}

class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
}

attachProperty(Person);

let someone = new Person('Someone', 47);
console.log(someone.toSpeciesString());