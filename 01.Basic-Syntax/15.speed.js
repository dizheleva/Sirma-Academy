function solution(meters, hours, minutes, seconds) {  
    let time = hours * 3600 + minutes * 60 + seconds;
    let speed = meters / time;  

    
    console.log(speed.toFixed(6));
}

solution(100, 1, 20, 20);
solution(2500, 5, 56, 23);
solution(600, 7, 35, 55);