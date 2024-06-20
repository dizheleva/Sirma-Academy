function solve(number) {
    let textNumber = number.toString();

    for (let ch = textNumber.length - 1; ch >= 0; ch--) {
        let digit = Number(textNumber[ch]);
        let charCode = digit + 33;
        let line = ``;
        if (digit === 0) {
            line = `ZERO`;
        } else {
            for (let i = 0; i < digit; i++) {
                line += String.fromCharCode(charCode);
            }
        }
        console.log(line);
    }
}

solve(2049);
solve(9347439);