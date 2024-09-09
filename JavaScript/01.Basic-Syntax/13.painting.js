function solution(yellow) {  
    let red = yellow / 4;
    let white = yellow * 2;
    let totalPaint = yellow + red + white;    
    
    console.log("Red : " + red);
    console.log("Yellow : " + yellow);
    console.log("White : " + white);
    console.log("Total : " + totalPaint);
}

solution(10);
solution(17);
solution(42);