class Cat {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    meow() {
        console.log(`${this.name}, age ${this.age} says meow`);
    }
}

function createPerson(input) {
    const cats = [];
    
    for (const line of input) {
        const [name, ageText] = line.split(' ');
        const age = Number(ageText);

        cats.push(new Cat(name, age));
    }  
    
    for (const cat of cats) {
        cat.meow();
    }
}

createPerson(['Mellon 2', 'Tom 3']);
createPerson(['Branch 1', 'Poppy 3', 'Goldy 2']);