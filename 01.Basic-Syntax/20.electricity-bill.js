function solution(units, rate) {  
    let totalBill = (units * rate) + 10
    console.log(totalBill.toFixed(2));
}

solution(100, 1.0);
solution(200, 1.0);
solution(150, 1.1);