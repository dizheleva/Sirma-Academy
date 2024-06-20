function solve(word) {    
    let mirrorWord = '';

    for (let i = word.length - 1; i >= 0; i--) {
        mirrorWord += word[i];
    }

    let isPalindrome = word === mirrorWord;    
    console.log(isPalindrome);
}

solve('radar');
solve('hello');
solve('racecar');
solve('java');
solve('madam');