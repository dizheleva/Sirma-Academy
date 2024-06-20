function solve(budget, season) {
    let place;
    let amount;
    let holidayType;

    if (budget <= 100) {
        place = "Somewhere in Bulgaria";

        if (season === "summer") {
            amount = 0.3 * budget;
            holidayType = "Camp";
        } else {
            amount = 0.7 * budget;
            holidayType = "Hotel";
        }
    } else if (budget <= 1000) {
        place = "Somewhere in Europe";

        if (season === "summer") {
            amount = 0.40 * budget;
            holidayType = "Camp";
        } else {
            amount = 0.8 * budget;
            holidayType = "Hotel";
        }
    } else {
        place = "Somewhere in Asia";
        amount = 0.9 * budget;
        holidayType = "Hotel";
    }
    
    let details = `${holidayType} - ${amount.toFixed(2)}`;
    console.log(place);
    console.log(details);
}

solve(50, "summer");
solve(75, "winter");
solve(312, "summer");
solve(678.53, "winter");
solve(1500, "summer");