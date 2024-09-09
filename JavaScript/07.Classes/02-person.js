class Person {
    constructor(firstNsme, lastName, age, email) {
        this.firstNsme = firstNsme;
        this.lastName = lastName;
        this.age = age;
        this.email = email;
    }

    toString() {
        let personToString = `${this.firstNsme} ${this.lastName} (age: ${this.age}, email: ${this.email})`
        return personToString;
    }
}

let person = new Person('Homer', 'Simpson', 42, 'homer@yahoo.com');
console.log(person.toString());