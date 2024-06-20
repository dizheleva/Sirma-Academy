function createPerson(name, surname, age) {
    let person = {
        firstName: name,
        lastName: surname,
        age,
    };

    return person;
}

function printObject(name, surname, age) {
    let personObj = createPerson(name,surname, age);
    console.log(personObj);
}

printObject("Ivan","Ivanov", 29);
printObject("Maria","Marinova", 13);