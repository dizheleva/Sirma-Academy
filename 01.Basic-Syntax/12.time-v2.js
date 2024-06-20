function solution(minutesOnly) {  
    let hours = Math.floor(minutesOnly / 60);
    let minutes = minutesOnly - hours * 60;
    
    function pad(num) {        
        return ('0' + num).slice(-2);
    }

    console.log(pad(hours) + ":" + pad(minutes));
}

solution(60);
solution(90);
solution(325);