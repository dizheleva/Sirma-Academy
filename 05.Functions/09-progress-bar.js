function appendNChars(text, character, n) {
    while (n > 0) {
        text += character;
        n--;
    }
    
    return text;
}

function visualizeLoading(n) {
    let symbolString = ''; 

    let percentCount = n / 10;
    symbolString = appendNChars(symbolString, '%', percentCount);

    let dotCount = 10 - percentCount;  
    symbolString = appendNChars(symbolString, '.', dotCount);  
    
    if (n < 100) {
        console.log(`${n}% [${symbolString}]`);
        console.log('Loading...');
    } else {
        console.log(`[${symbolString}]`);
        console.log('Complete!');
    }
}

visualizeLoading(30);
visualizeLoading(50);
visualizeLoading(100);