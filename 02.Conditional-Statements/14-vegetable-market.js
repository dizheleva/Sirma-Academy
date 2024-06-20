function solve(vegetable, day, quantity) {
    let price;
    let result;

    switch (day) {
        case "Saturday":
        case "Sunday":
            switch (vegetable) {
                case "tomato":
                    price = 2.80;
                    break;
                case "onion":
                    price = 1.30;
                    break;
                case "lettuce":
                    price = 0.85;
                    break;
                case "cucumber":
                    price = 1.75;
                    break;
                case "pepper":
                    price = 3.50;
                    break;
                default:
                    result = "error";
                    break;
            }
            break;
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
            switch (vegetable) {
                case "tomato":
                    price = 2.50;
                    break;
                case "onion":
                    price = 1.20;
                    break;
                case "lettuce":
                    price = 0.85;
                    break;
                case "cucumber":
                    price = 1.45;
                    break;
                case "pepper":
                    price = 5.50;
                    break;
                default:
                    result = "error";
                    break;
            }
            break;
    
        default:
            result = "error";
            break;
    }
    

    if (!result) {
        result = (price * quantity).toFixed(2);
    }  
    console.log(result);
}

solve("tomato", "Tuesday", 2);
solve("onion", "Sunday", 3);
solve("pepper", "Monday", 10);
solve("banana", "Friday", 5);