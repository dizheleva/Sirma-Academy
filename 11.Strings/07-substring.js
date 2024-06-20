function decrypt(word, text) {
    const indexCheck = text.toLowerCase().indexOf(word);
    const result = indexCheck !== -1 ? word : `${word} not found!`;
    
    console.log(result);
}

decrypt('javascript', 'JavaScript is the best programming language');
decrypt('python', 'JavaScript is the best programming language');