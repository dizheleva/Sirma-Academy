function solve(arr) {
    for (let i = 0; i < arr.length / 2; i++) {
        let currentElement = arr[i];
        arr[i] = arr[arr.length - 1 - i];
        arr[arr.length - 1 - i] = currentElement;
    }

    console.log(arr.join(' '));
}

solve(['a', 'b', 'c', 'd', 'e']);
solve(['abc', 'def', 'hig', 'klm', 'nop']);
solve(['33', '123', '0', 'dd']);