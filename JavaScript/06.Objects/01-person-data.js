function createPerson(name, surname, age) {
    let person = {
        firstName: name,
        lastName: surname,
        age,
    };

    return person;
}

function printObject(person) {
    console.log(person);
}

function solve(name,surname, age) {
    let person = createPerson(name,surname, age);
    printObject(person);
}

solve("Ivan","Ivanov", 29);
solve("Maria","Marinova", 13);