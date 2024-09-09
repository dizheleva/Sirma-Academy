function solve(year, material) {
    let style;

    if (year < 500 && material === "stone") {
        style = "Ancient";
    } else if (year >= 500 && year <= 1500 && material === "stone") {
        style = "Medieval";
    } else if (year >= 1500 && year <= 1800 && material === "wood") {
        style = "Colonial";
    } else if (year >= 1800 && year <= 1900 && material === "steel") {
        style = "Industrial";
    } else if (year > 1900 && material === "steel") {
        style = "Modern";
    } else {
        style = "Uncertain";       
    } 
        
    console.log(style);
}

solve(300, "stone");
solve(1500, "wood");
solve(1500, "stone");
solve(2000, "steel");
solve(1100, "wood");