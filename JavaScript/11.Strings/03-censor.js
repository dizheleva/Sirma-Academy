function decrypt(text, word) {
    const censoredWord = '*'.repeat(word.length)
    const censoredText = text.replaceAll(word, censoredWord);

    console.log(censoredText);
}

decrypt('A small sentence with some words', 'small');
decrypt('Find the hidden word', 'hidden');
decrypt('A small sentence with small words', 'small');