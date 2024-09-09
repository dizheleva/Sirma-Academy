function solve(k, arr) {
    let firstNumbersArr = [];
    let lastNumbersArr = [];

    for (let i = 0; i < k; i++) {
        firstNumbersArr.push(arr[i]);
        lastNumbersArr.unshift(arr[arr.length - 1 -i]);
    }

    console.log(firstNumbersArr.join(' '));
    console.log(lastNumbersArr.join(' '));
}

solve(2, [7, 8, 9]);
solve(3, [6, 7, 8, 9]);