function solve(days, roomType, assessment) {
    const singleRoomPrice = 25.00;
    const apartmentPrice = 50.00;
    const presidentialPrice = 100.00;

    let discount;
    let roomPrice;

    if (days < 10) {
        switch (roomType) {
            case "single room":
                discount = 0;  
                roomPrice = singleRoomPrice;              
                break;
            case "apartment":
                discount = 0.3;
                roomPrice = apartmentPrice;
                break;
            case "president apartment":
                discount = 0.1;
                roomPrice = presidentialPrice;
                break;
        }
    } else if (days <= 15) {
        switch (roomType) {
            case "single room":
                discount = 0;
                roomPrice = singleRoomPrice;
                break;
            case "apartment":
                discount = 0.35;
                roomPrice = apartmentPrice;
                break;
            case "president apartment":
                discount = 0.15;
                roomPrice = presidentialPrice;
                break;
        }
    } else {
        switch (roomType) {
            case "single room":
                discount = 0;
                roomPrice = singleRoomPrice;
                break;
            case "apartment":
                discount = 0.5;
                roomPrice = apartmentPrice;
                break;
            case "president apartment":
                discount = 0.2;
                roomPrice = presidentialPrice;
                break;
        }
    }

    let totalPrice = (days - 1) * roomPrice * (1 - discount); 
    
    if (assessment === "positive") {
        totalPrice += 0.25 * totalPrice;
    } else if (assessment === "negative") {
        totalPrice -= 0.1 * totalPrice
    }

    console.log(totalPrice.toFixed(2));
}    

solve(11, "apartment", "positive");
solve(30, "president apartment", "negative");
solve(12, "single room", "positive");
solve(2, "apartment", "positive");