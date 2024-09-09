function convertToObject(text) {
    let data = JSON.parse(text);

    for (let key in data) {
        console.log(key + ': ' + data[key]);
    }
}

convertToObject('{"name": "Ivan", "age": 40, "town": "Sofia"}');
convertToObject('{"firstName": "Ivan", "lastName": "Ivanov"}');