function decrypt(wordList, text) {
    let words = wordList
        .split(', ')
        .sort((a, b) => b.length - a.length);

    let result = text; 

    for (const word of words) {
        let search = '*'.repeat(word.length);
        result = result.replaceAll(search, word);
    }

    console.log(result);
}

decrypt('great', 'JavaScript* is ***** language');
decrypt('the, best, learn', 'JavaScript* is *** **** language to *****');