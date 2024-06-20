function solution(distance, fuel) {  
    let efficiency = distance / fuel;

    console.log(efficiency.toFixed(2));
}

solution(500, 40);
solution(600, 40);
solution(750, 40);