class Employee {
    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    printInfo() {
        console.log(`Name: ${this.name}. Base salary: $${this.salary}`);
    }
}

class Manager extends Employee {
    subordinates = [];

    constructor(name, salary, subordinates) {
        super(name, salary);
        this.subordinates = subordinates;
    }

    getBonusSalary() {
        const bonus = 0.05 * this.subordinates.length;
        return (bonus * this.salary) + this.salary;
    }

    printInfo() {
        super.printInfo();
        console.log(`--> Manager with bonus salary: $${this.getBonusSalary()}`);
    }
}

class Engeneer extends Employee {
    constructor(name, salary, years) {
        super(name, salary);
        this.years = years;
    }

    getBonusSalary() {
        const bonus = 0.03 * this.years;
        return (bonus * this.salary) + this.salary;
    }

    printInfo() {
        super.printInfo();
        console.log(`--> Engeneer with bonus salary: $${this.getBonusSalary()}`);
    }
}

const emp1 = new Engeneer('Marko Polo', 1000, 2);
const emp2 = new Engeneer('Fernando Alonso', 2000, 6);
const emp3 = new Engeneer('Enrique Iglesias', 1800, 5);

const manager = new Manager('Dua Lipa', 5000, [emp1, emp2, emp3]);

manager.printInfo();
manager.subordinates.forEach(emp => emp.printInfo());