function decrypt(input) {
    const pattern = /(\b[A-Z][a-z]+ [A-Z][a-z]+)/g;

    const matches = input.matchAll(pattern);

    for (const match of matches) {
        console.log(match[1]);
    }
}

decrypt('Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov');