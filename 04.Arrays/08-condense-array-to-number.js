function solve(arr) {
    while (arr.length > 1) {
        let condensedArray = [];

        for (let i = 0; i < arr.length - 1; i++) {
            let condenseValue = arr[i] + arr[i + 1];

            condensedArray.push(condenseValue);
        }

        arr = condensedArray;
    }

    console.log(arr[0]);
}

solve([2, 10, 3]);
solve([5, 0, 4, 1, 2]);
solve([1]);