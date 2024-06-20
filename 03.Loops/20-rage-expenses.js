function solve(lostGames, headsetPrice, mousePrice, keyboardPrice, displayPrice) {
    
    let headsetsCost = 0;
    let mousesCost = 0;
    let keyboardsCost = 0;
    let displaysCost = 0;
    
    let keyboardsCounter = 0;
    for (let game = 1; game <= lostGames; game++) {
        
        if (game % 2 === 0) {
            headsetsCost += headsetPrice;
        }
        if (game % 3 === 0) {
            mousesCost += mousePrice;
        } 
        if (game % 2 === 0 && game % 3 === 0) {
            keyboardsCost += keyboardPrice;
            keyboardsCounter++;
            if (keyboardsCounter % 2 === 0) {
                displaysCost += displayPrice;
                keyboardsCounter = 0;
            } 
        }        
    }
    let totalCost = headsetsCost + mousesCost + keyboardsCost + displaysCost;
    
    console.log(`Rage expenses: ${totalCost.toFixed(2)} lv.`);
}

solve(7, 2, 3, 4, 5);
solve(23, 12.50, 21.50, 40, 200);