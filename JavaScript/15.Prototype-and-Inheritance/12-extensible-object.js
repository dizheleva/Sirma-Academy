function getExtesibleObject() {
    const Extensible = {
        extend: function (template) {
            for (const key in template) {
                if (template.hasOwnProperty(key)) {
                    const property = template[key];
                    if (typeof property === 'function') {
                        Object.getPrototypeOf(this)[key] = property;
                    } else {
                        this[key] = property;
                    }
                }
            }
        }
    }

    return Extensible;
}

const person = {
    name: 'Ivan',
    age: 27,
    printInfo: function () {
        console.log(`I am ${this.name}, ${this.age} years old.`);
    }
};

const extensibleObj = getExtesibleObject();
extensibleObj.extend(person);
console.log(Object.getPrototypeOf(extensibleObj));
console.log(extensibleObj);
extensibleObj.printInfo();