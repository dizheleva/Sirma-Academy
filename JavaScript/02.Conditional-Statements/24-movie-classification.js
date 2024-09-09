function solve(age) {
    const childCategory = "U-rated movies";
    const teenCategory = "U and PG-13 rated movies";
    const adultCategory = "All movies";

    let output;
    if (age < 13) {
        output = childCategory;
    } else if (age >= 13 && age <= 17 ) {
        output = teenCategory;
    } else {
        output = adultCategory;        
    } 
        
    console.log(output);
}

solve(10);
solve(16);
solve(21);