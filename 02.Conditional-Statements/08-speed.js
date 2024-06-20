function solve(number) {
    
    if (number <= 10) {
       console.log("slow"); 
    } else if ( number > 10 && number <= 60) {
        console.log("average");
    } else if ( number > 60 && number <= 120) {
        console.log("fast");
    } else if ( number > 120 && number <= 160) {
        console.log("super-fast");
    } else if ( number > 160) {
        console.log("turbo-fast");
    }
}

solve(10);
solve(59);
solve(120);
solve(121);
solve(183);
solve(59.99);
solve(60.001);