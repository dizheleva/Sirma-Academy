function printCharacters(a, b) {
    let startCode = a.charCodeAt(0);
    let endCode = b.charCodeAt(0);
    let range = findSmaller(startCode, endCode) + Math.abs(startCode - endCode);
    let beggining = findSmaller(startCode, endCode) + 1;

    let output = '';
    for (let i = beggining; i < range; i++) {
       output += String.fromCharCode(i);        
    }

    console.log(output);
}

function findSmaller(first, second) {
    return first < second ? first : second;
}

printCharacters('a', 'd');
printCharacters('#', ':');
printCharacters('C', '#');