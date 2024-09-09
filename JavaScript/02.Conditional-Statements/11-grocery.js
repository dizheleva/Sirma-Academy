function solve(product, city, quantity) {
    let price;

    switch (city) {
        case "Sofia":
            switch (product) {
                case "tea":
                    price = 0.5;
                    break;
                case "water":
                    price = 0.8;
                    break;
                case "juice":
                    price = 1.2;
                    break;
                case "sweets":
                    price = 1.45;
                    break;
                case "chips":
                    price = 1.6;
                    break;
            }
            break;
        case "Plovdiv":
            switch (product) {
                case "tea":
                    price = 0.4;
                    break;
                case "water":
                    price = 0.7;
                    break;
                case "juice":
                    price = 1.15;
                    break;
                case "sweets":
                    price = 1.30;
                    break;
                case "chips":
                    price = 1.5;
                    break;
            }
            break;
        case "Varna":
            switch (product) {
                case "tea":
                    price = 0.45;
                    break;
                case "water":
                    price = 0.7;
                    break;
                case "juice":
                    price = 1.1;
                    break;
                case "sweets":
                    price = 1.35;
                    break;
                case "chips":
                    price = 1.55;
                    break;
            }
            break;        
    }

    let result = price * quantity;
    console.log(result.toFixed(2));
}

solve("tea", "Varna", 2);
solve("chips", "Plovdiv", 1);
solve("juice", "Sofia", 6);
solve("sweets", "Plovdiv", 1);