function createPerson(firstName, lastName, eyeColor) {
    let person = {
        name: firstName,
        lastName: lastName,
        eyeColor: eyeColor,
    };

    return person;
}

function printJsonPerson(name, surname, color) {
    let person = createPerson(name, surname, color);

    let personJSON = JSON.stringify(person);

    console.log(personJSON);
}

printJsonPerson("Ivan", "Ivanov", "blue");
printJsonPerson("Maria", "Petrova", "brown");