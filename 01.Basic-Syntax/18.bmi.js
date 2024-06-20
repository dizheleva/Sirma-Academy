function solution(weight, height) {  
    let bmi = weight / Math.pow(height, 2);  
    
    console.log(bmi.toFixed(2));
}

solution(70, 1.73);
solution(60, 1.75);
solution(85, 1.80);