function solve(arr, n) {
    while (n > 0) {
        arr.unshift(arr.pop());
        n--;
    }

    console.log(arr.join(' '));
}

solve(['1', '2', '3', '4'], 2);
solve(['Banana', 'Orange', 'Coconut', 'Apple'], 15);