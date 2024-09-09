function solve(age, status) {
    let discount;

    if (age < 18) {
        discount = 10;
    } else if (age >= 18 && age <= 64 ) {
        if (status === "Yes") {
            discount = 20;
        } else {
            discount = 10;
        }
    } else {
        discount = 30;        
    } 
        
    let output = `${discount}% discount`;
    console.log(output);
}

solve(20, "Yes");
solve(15, "No");
solve(70, "No");