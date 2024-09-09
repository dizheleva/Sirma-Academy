function solve(arr) {
    let outputArr = [];
 
    for (let i = 0; i < 2; i++) {
        let smallest = Math.min(...arr);
        outputArr.push(smallest);
        let smallestIndex = arr.indexOf(smallest);
        arr.splice(smallestIndex);
    }

    console.log(outputArr.join(' '));
}
 
solve([30, 15, 50, 5]);
solve([3, 0, 10, 4, 7, 3]);