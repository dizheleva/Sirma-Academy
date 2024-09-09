function solve(amount) {
    let coinCounter = 0;    
    let changeInCents = Math.floor(amount * 100);
    while (changeInCents > 0.00) { 
        if (changeInCents >= 200) {
            changeInCents -= 200;
        } else if (changeInCents >= 100) {
            changeInCents -= 100;
        } else if (changeInCents >= 50) {
            changeInCents -= 50;
        } else if (changeInCents >= 20) {
            changeInCents -= 20;
        } else if (changeInCents >= 10) {
            changeInCents -= 10;
        } else if (changeInCents >= 5) {
            changeInCents -= 5;
        } else if (changeInCents >= 2) {
            changeInCents -= 2;
        } else if (changeInCents === 1) {
            changeInCents--;
        }
        coinCounter++;  
    }
    console.log(coinCounter);
}

solve(1.23);
solve(2);
solve(0.56);
solve(2.73);