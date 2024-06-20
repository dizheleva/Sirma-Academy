function solve(year) {
    let result;
    
    if ( year % 4 != 0 || (year % 100 === 0 && year % 400 != 0)) {
        result = "It‘s not a leap year.";
    } else {
        result = "It‘s a leap year!";
    }   
        
    console.log(result);
}

solve(2020);
solve(1900);
solve(2000);
solve(2023);
solve(1600);