function solve(inputData) {
    let arr = inputData.shift().split(' ').map(Number);

    for (let i = 0; i < inputData.length; i++) {
        let attributes = inputData[i].split(' ');
        let command = attributes[0];
        let firstNum = Number(attributes[1]);
        let secondNum = Number(attributes[2]);
        switch (command) {
            case 'Add':
                arr.push(firstNum);
                break;
            case 'Remove':
                arr = arr.filter(el => el !== firstNum);;
                break;
            case 'RemoveAt':
                arr.splice(firstNum, 1);
                break;
            case 'Insert':
                arr.splice(secondNum, 0, firstNum);;
                break;
        }
    }
    console.log(arr.join(' '));
}

solve(['4 19 2 53 6 43', 'Add 3', 'Remove 2', 'RemoveAt 1', 'Insert 8 3']);