// Object introduction:
const object = {
    fieldsCollection: [],
    propertyKey: "propertyValue",
    propsCount: 3
}

// dot-notation:
const personPeter = { name: 'Peter' };
console.log(personPeter.name); // Peter

//Bracket-notation (indexing operator)
// -> Required if the key contains a special character
// -> Brackets can be used with keys as string variables
personPeter['address'] = 'My address';
console.log(personPeter['address']);

//Destructuring Syntax
const company = {
    name: 'Demo LTD.',
    ceo: 'John Doe',
    employeeCount: 123
};

const { name, ceo } = company;
console.log(name, ceo);

// Deleting Properties

const person = {
    name: 'Peter',
    age: 30,
    ['address']: 'My address'
}; // Object {name: 'Peter', age: 30, 'address': 'My address' }

delete person.age; // Object {name: 'Peter', 'address': 'My address' }
console.log(person.age) // undefined

//Object References
let x = { name: 'John' };
let y = x;
y.name = "Doe";
console.log(x.name); // Doe

//Associative Arrays
const obj = { a: 10, b: 20, c: 30 };
for (const key in obj) {
    console.log(`obj.${key} = ${obj[key]}`);
}

//Object Keys and Values
const phonebook = {
    'Jerry': '555-111',
    'Tom': '555-222',
};
const keys = Object.keys(phonebook);
console.log(keys); // ['Jerry', 'Tom']
const values = Object.values(phonebook);
console.log(values); // ['555-111', '555-222']

//Object Entries - Get an array of tuples (key - value pairs)
const entries = Object.entries(phonebook);
console.log(entries);
// [ ['Jerry', '555-111'],
// ['Tom', '555-222'] ]

//Object Methods
let personJohn = {
    firstName: "John",
    lastName: "Doe",
    age: function (paramAge) { return `My age is ${paramAge}!` }
};
console.log(personJohn.age(30)); // My age is 30!

//Objects as Function Libraries
const sortingHelper = {
    ascending: (a, b) => a - b,
    descending: (a, b) => b - a
};

//Objects as switch
let count = 0;
const commandExecutor = {
    increment() { count++; },
    decrement() { count--; },
    reset() { count = 0; }
}
//commandExecutor[command]();

//Accessing Object Context (this)
const personJon = {
    firstName: 'Jon',
    lastName: 'Snow',
    fullName() { return this.firstName + ' ' + this.lastName; }
};
console.log(personJon.fullName()); // 'Jon Snow'

//Function Execution Context
const getFullName = personJon.fullName;
console.log(getFullName()); // 'undefined undefined'
const anotherPerson = { firstName: 'Jon', lastName: 'Snow' };
anotherPerson.fullName = getFullName;
console.log(anotherPerson.fullName()); // 'Jon Snow'

//Object Composition
let point = {
    color: 'red',
    size: 22,
    position: { x: 10, y: 20 }
}
console.log(point);
console.log(point.position.x);

//Composing by behaviour
function print() { console.log(`${this.name} is printing a page`); }
function scan() { console.log(`${this.name} is scanning a document`); }
const printer = { name: 'Brother Printer', print };
const scanner = { name: 'Cannon Scanner', scan };
const copier = { name: 'Xerox', print, scan };

//Factory Functions With Reference - Functions that compose and return objects
function createRectangle(width, height) {
    const rectangle = { width, height };
    rectangle.getArea = () => {
        return rectangle.width * rectangle.height;
    };
    return rectangle;
}

//Function Decoration
function canPrint(machine) {
    machine.print = () => {
        console.log(`${machine.name} is printing`);
    }
}
const machine = { name: 'Xerox' };
canPrint(machine);
machine.print();

//JSON
// --Data is in name/value pairs
// --Data is separated by commas
// --Curly braces hold objects
// --Square brackets hold arrays
// --JSON only takes double quotes ""
// {
//     "friends": [
//         { "firstName": "Ross", "lastName": "Geller" },
//         { "firstName": "Monica", "lastName": "Geller" },
//         { "firstName": "Chandler", "lastName": "Bing" }
//     ]
// }

//Parsing from Strings - JSON.stringify(), JSON.parse
let someone = { name: "John", age: 30};
let jsonSomeone = JSON.stringify(someone);
console.log(jsonSomeone); // '{"name":"John","age":30}'
let someoneElse = JSON.parse('{"name":"John","age":30}');
console.log(someoneElse.name);