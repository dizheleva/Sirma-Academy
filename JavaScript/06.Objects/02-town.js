function printTownObject(town) {
    for (const key of Object.keys(town)) {
        console.log(key + ' -> ' + town[key]);
    }
}

printTownObject(
    {
        name: "Sofia",
        population: 1234567,
        country: "Bulgaria",
        postcode: "1000"
    }
);