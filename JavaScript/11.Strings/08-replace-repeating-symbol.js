function decrypt(input) {
    let result = input;

    for (let i = 0; i < input.length - 1; i++) {
        if (input[i] === input[i + 1]) {
            result = result.replace(input.substring(i, i + 2), input[i]);           
        }
    }
    
    console.log(result);
}

decrypt('aaaaabbbbbcdddeeeedssaa');
decrypt('qqqwerqwecccwd');