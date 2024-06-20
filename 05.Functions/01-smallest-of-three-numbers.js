function findSmaller(first, second) {
    return first < second ? first : second;
}

function findSmallestOfThree(first, second, third) {
    let result = findSmaller(findSmaller(first, second), third);

    console.log(result);
}

findSmallestOfThree(2, 5, 3);
findSmallestOfThree(600, 342, 123);
findSmallestOfThree(25, 21, 4);