function solve(n, arr) {
    let reversedArr = [];

    for (let i = n - 1; i >= 0; i--) {
        reversedArr.push(arr[i]);
    }

    console.log(reversedArr.join(' '));
}

solve(3, [10, 20, 30, 40, 50]);
solve(4, [-1, 20, 99, 5]);
solve(2, [66, 43, 75, 89, 47]);