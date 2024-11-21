class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
}

class Student extends Person {
    constructor(name, age, school) {
        super(name, age);
        this.school = school;
    }
}

let student = new Student('Someone', 'Noone', 'Some school');
console.log(student)