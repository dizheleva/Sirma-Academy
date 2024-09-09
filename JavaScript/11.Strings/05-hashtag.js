function decrypt(input) {
    const pattern = /#([a-z]+)/g;

    const matches = input.matchAll(pattern);

    for (const match of matches) {
        console.log(match[1]);
    }
}

decrypt('Everyone uses # to tag a #special word in #facebook');
decrypt('The symbol # is known #variously in English-speaking #regions as the #number sign');