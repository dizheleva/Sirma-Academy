function solve(renovationPrice, powders, lipsticks, spirals, shadows, correctors) {
    const powderPrice = 2.60;
    const lipstickPrice = 3;
    const spiralPrice = 4.10;
    const shadowsPrice = 8.20;
    const correctorPrice = 2;

    let orderTotal = powders * powderPrice 
                    + lipsticks * lipstickPrice 
                    + spirals * spiralPrice 
                    + shadows * shadowsPrice 
                    + correctors * correctorPrice; 

    let productCount = powders + lipsticks + spirals + shadows + correctors;    
    if (productCount >= 50) {
        orderTotal = orderTotal - 0.25 * orderTotal;
    }

    let rent = 0.1 * orderTotal; 
    let shopIncome = orderTotal - rent; 
    let result = (shopIncome - renovationPrice).toFixed(2);   
    let output;

    if (result >= 0) {
        output = `Yes! ${result} BGN left.`;
    } else {
        output = `Not enough money! ${Math.abs(result)} BGN needed.`;
    }
    console.log(output);
}    

solve(40.8, 20, 25, 30, 50, 10);
solve(320, 8, 2, 5, 5, 1);