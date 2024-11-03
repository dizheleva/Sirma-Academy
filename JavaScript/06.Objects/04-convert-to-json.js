function createPerson(firstName, lastName, eyeColor) {
    let person = {
        name: firstName,
        lastName: lastName,
        eyeColor: eyeColor,
    };

    return person;
}

function printJsonPerson(person) {
    let personJSON = JSON.stringify(person);

    console.log(personJSON);
}

function solve(name, surname, color) {
    let person = createPerson(name, surname, color);
    printJsonPerson(person);
}

solve("Ivan", "Ivanov", "blue");
solve("Maria", "Petrova", "brown");