function isPerfectNumber(n) {
    let sum = 0;
    let dividers = []; 
    
    for (let i = 1; i < n; i++) {
        if (n % i === 0) {
            sum += i;
            dividers.push(i);
        }
    }

    if (sum === n) {
        console.log(`Prfect number!`);
        console.log(dividers.join(' + '));
    } else {
        console.log(`It's not so perfect.`);
    }
}
 
isPerfectNumber(6);
isPerfectNumber(28);
isPerfectNumber(1236498);