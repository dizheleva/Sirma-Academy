function solution(numOne, numTwo) {  
    let sum = numOne + numTwo; 
    let difference = Math.abs(numOne - numTwo);
    let product = numOne * numTwo;
    let average = sum / 2; 

    console.log("Sum: " + sum);
    console.log("Difference: " + difference);
    console.log("Product: " + product);
    console.log("Average: " + average);
}

solution(25, 5);
solution(7, 14);
solution(12, 1);