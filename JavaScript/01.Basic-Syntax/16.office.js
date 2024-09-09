function solution(firstCabinet) {  
    let secondCabinet = firstCabinet - 0.2 * firstCabinet;
    let thirdCabinet = 1.15 * (firstCabinet + secondCabinet);
    let totalCost = firstCabinet + secondCabinet + thirdCabinet;    
    
    console.log(totalCost.toFixed(3));
}

solution(380);
solution(720.50);
solution(455.30);