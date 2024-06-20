function solve(arr) {
    let outputArr = [];
 
    for (let i = arr.length - 1; i >= 0; i-=2) {
        let number = arr[i] * 2;
        outputArr.push(number);
    }

    console.log(outputArr.join(' '));
}
 
solve([10, 15, 20, 25]);
solve([3, 0, 10, 4, 7, 3]);