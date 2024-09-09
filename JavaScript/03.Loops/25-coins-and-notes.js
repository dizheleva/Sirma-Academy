function solve(coinsOne, coinsTwo, notesFive, sum) {    
    for (let cOne = 0; cOne <= coinsOne; cOne++) {
        for (let cTwo = 0; cTwo <= coinsTwo; cTwo++) {
            for (let nFive = 0; nFive <= notesFive; nFive++) {
                if (cOne + cTwo * 2 + nFive * 5 === sum) {
                    let output = `${cOne} * 1 lv. + ${cTwo} * 2 lv. + ${nFive} * 5 lv. = ${sum} lv.`;
                    console.log(output);
                }
            }
        }    
    }    
}

solve(3, 2, 3, 10);
solve(5, 3, 1, 7);