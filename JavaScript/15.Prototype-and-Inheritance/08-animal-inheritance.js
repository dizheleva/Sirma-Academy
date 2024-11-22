class Animal {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    eat() {
        console.log(`${this.name} is eating`)
    }

    sleep() {
        console.log(`${this.name} is sleeping`)
    }

    makeSound() {
        console.log(`${this.name} is making sound`);
    }
}

class Dog extends Animal {
    sound = 'Bark!';

    constructor(name, age) {
        super(name, age);
    }

    makeSound() {
        super.makeSound();
        console.log(this.sound);
    }
}

class Cat extends Animal {
    sound = 'Meow!';

    constructor(name, age) {
        super(name, age);
    }

    makeSound() {
        super.makeSound();
        console.log(this.sound);
    }
}

const dog = new Dog('Sharo', 3);
dog.makeSound();

const cat = new Cat('Matsa', 1);
cat.makeSound();