function solve(n, k) {
    let arr = [1];
    while (n > 1) {
        let nextElement = 0;
        let stopSumming = arr.length > k ? k : arr.length;

        for(let i = 0; i < stopSumming; i++){
            nextElement += arr[arr.length - i - 1];
        }
        arr.push(nextElement);
        n--;
    }

    console.log(arr.join(' '));
}

solve(6, 3);
solve(8, 2);