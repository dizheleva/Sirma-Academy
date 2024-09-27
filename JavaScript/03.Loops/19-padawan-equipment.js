function solve(money, students, saberPrice, robePrice, beltPrice) {
    
    let sabersCost = Math.ceil(1.1 * students) * saberPrice;
    let robesCost = students * robePrice;
    let beltsCost = (students - Math.floor(students / 6)) * beltPrice;
    let totalCost = sabersCost + robesCost + beltsCost;
    
    let result;
    if (money >= totalCost) {
        result = `The money is enough - it would cost ${totalCost.toFixed(2)}lv.`;
    } else {
        result = `George Lucas will need ${(totalCost - money).toFixed(2)}lv more.`;
    }
    console.log(result);
}

solve(100, 2, 1.0, 2.0, 3.0);
solve(100, 42, 12.0, 4.0, 3.0);