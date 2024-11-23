function createSchoolSytem() {
    class Person {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }
    }

    class Student extends Person {
        constructor(name, age, grade, school) {
            super(name, age);
            this.grade = grade;
            this.school = school;
        }

        study() {
            console.log(`${this.name} studied in ${this.grade} grade.`);
        }
    }

    class Teacher extends Person {
        constructor(name, age, subject, salary) {
            super(name, age);
            this.subject = subject;
            this.salary = salary;
        }

        teach() {
            console.log(`${this.name} teached ${this.subject} to the class.`)
        }
    }

    return {Person, Student, Teacher};
}