function solve(a, b, operation) {
    let result;

    switch (operation) {
        case "add":
            result = a + b;
            break;
        case "subtract":
            result = a - b;
            break;
        case "divide":
            result = a / b;
            break;
        case "multiply":
            result = a * b;
            break;        
    }

    // console.log(result.toFixed(2));
    console.log(Math.round(result * 100) / 100);
}    

solve(5, 5, "add");
solve(10, 12, "subtract");
solve(9, 3, "divide");
solve(5, 2, "divide");
solve(3.1, 0.1, "multiply");