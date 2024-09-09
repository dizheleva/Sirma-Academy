function solve(arr, step) {
    let outputArr = [];
    for (let i = 0; i < arr.length; i+=step) {
        outputArr.push(arr[i]);
    }

    console.log(outputArr.join(' '));
}

solve(['5', '15', '31', '14', '20'], 2);
solve(['dsa', 'asd', 'demo', 'test'], 2);
solve(['1', '2', '3', '4', '5'], 6);