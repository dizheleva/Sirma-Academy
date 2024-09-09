function solution(minutesOnly) {  
    let hours = Math.floor(minutesOnly / 60);
    let minutes = minutesOnly - hours * 60;

    console.log(hours + ":" + minutes);
}

solution(60);
solution(90);
solution(325);