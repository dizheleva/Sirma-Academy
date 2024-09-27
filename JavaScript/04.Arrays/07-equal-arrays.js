function solve(firstArr, secondArr) {
    let sum = 0;
    let isIdentical = true;
    let index = null;
    
    for (let i = 0; i < firstArr.length; i++) {
        if (firstArr[i] === secondArr[i]) {
            sum += Number(firstArr[i]);
        } else {
            isIdentical = false;
            index = i;
            break;
        }
    }

    if (isIdentical) {
        console.log(`Arrays are identical. Sum: ${sum}`);
    } else {
        console.log(`Arrays are not identical. Found difference at ${index} index`);
    }
}

solve(['10', '20', '30'], ['10', '20', '30']);
solve(['1', '2', '3', '4', '5'], ['1', '2', '4', '4', '5']);
solve(['1'], ['10']);