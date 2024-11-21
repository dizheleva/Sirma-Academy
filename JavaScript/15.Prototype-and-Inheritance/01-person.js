function createPerson(firstName, lastName) {
    let person = {
        firstName: firstName,
        lastName: lastName
    }

    Object.defineProperty(person, 'fullName', {
        get: function () {
            return `${this.firstName} ${this.lastName}`;
        },
        set: function (value) {
            let [newFirstName, newLastName] = value.split(' ');

            if (newFirstName && newLastName) {
                this.firstName = newFirstName;
                this.lastName = newLastName;
            }
        }
    });

    return person;
}

let someone = createPerson('Someone', 'Someoneson');
someone.fullName = 'Someoneelse Someoneson';
console.log(someone.firstName);