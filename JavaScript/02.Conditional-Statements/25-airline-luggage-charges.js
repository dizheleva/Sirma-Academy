function solve(weight, dimensions) {
    let isOverweight = false;
    let isOversized = false;
    let isSlightlyOversized = false;

    let fee = 0;

    if (weight > 50) {
        fee += 100;
        isOverweight = true;
    } 

    if (dimensions > 158) {
        let exceeding = dimensions - 158;
        if (exceeding <= 20) {
            fee += 50;
            isSlightlyOversized = true;
        } else if (exceeding <= 50) {
            fee += 100;
            isOversized = true;
        } else {
            fee += 200;
            isOversized = true;
        }
    }

    if (isOverweight && isOversized) {
        fee += 50;
    }
    
    let output = `$${fee} (`;
    if (isOverweight) {
        output += `Overweight`;
        if (isSlightlyOversized) {
            output += ` + Slightly oversize`;
        } else if (isOversized) {
            output += ` + Oversize + Handling`;
        }
        output += `)`;
    } else {
        if (isSlightlyOversized) {
            output += `Slightly oversize`;
        } else if (isOversized) {
            output += `Oversize`;
        }
        output += `)`;
    }    

    console.log(output);
}

solve(52, 160);
solve(48, 180);
solve(55, 190);