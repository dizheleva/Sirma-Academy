function solve(age) {
    let price;

    if (age <= 12) {
        price = 5;
    } else if (age <= 19) {     
        price = 8;
    } else {
        price = 10;
    }

    console.log("$" + price);
}

solve(10);
solve(16);
solve(25);
solve(13);