function solve(arr) {
    let inputNumber = 1;
    let outputArr = [];
    
     for (const element of arr) {
        if (element === 'add') {
            outputArr.push(inputNumber);
            inputNumber++;
        } else if (element === 'remove') {
            outputArr.pop();
        }
     }

     if (outputArr.length != 0) {
        console.log(outputArr.join(' '));       
     } else {
        console.log('Empty');
     }
}

solve(['add', 'add', 'add', 'add']);
solve(['add', 'add', 'remove', 'add', 'add']);
solve(['remove', 'remove', 'remove']);