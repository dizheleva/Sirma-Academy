function solve(number) {
    let output;

    if (number % 2 === 0) {
        output = "even"; 
    } else {
        output = "odd";
    }

    console.log(output);
}

solve(2);
solve(3);
solve(25);
solve(1024);