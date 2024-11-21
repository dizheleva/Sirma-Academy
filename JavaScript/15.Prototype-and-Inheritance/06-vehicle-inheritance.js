class Vehicle {
    constructor(make, model) {
        this.make = make;
        this.model = model;
    }

    printInfo() {
        return `Make: ${this.make}\nModel: ${this.model}`;
    }
}

class Car extends Vehicle {
    constructor(make, model, doors) {
        super(make, model);
        this.doors = doors;
    }

    printInfo() {
        return `${super.printInfo()}\nDoors: ${this.doors}`;
    }
}

class Bike extends Vehicle {
    constructor(make, model, type) {
        super(make, model);
        this.type = type;
    }

    printInfo() {
        return `${super.printInfo()}\nType: ${this.type}`;
    }
}

const car = new Car('Skoda', 'Octavia', 5);
console.log(car.printInfo());