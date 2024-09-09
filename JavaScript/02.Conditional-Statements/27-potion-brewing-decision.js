function solve(ingredientOne, ingredientTwo) {
    let potion = "No potion";

    if (ingredientOne === "herbs" || ingredientTwo === "herbs") {
        if (ingredientOne === "water" || ingredientTwo === "water") {
            potion = "Health potion";
        } else if (ingredientOne === "oil" || ingredientTwo === "oil") {
            potion = "Stealth potion";
        } else {
            potion = "Minor stamina potion";
        }
    } 

    if (ingredientOne === "berries" || ingredientTwo === "berries") {        
        if (ingredientOne === "sugar" || ingredientTwo === "sugar") {
            potion = "Speed potion";
        } else {
            potion = "Minor energy potion";
        }
    }
    
    console.log(potion);
}

solve("herbs", "water");
solve("herbs", "oil");
solve("herbs", "banana");
solve("berries", "sugar");
solve("berries", "banana");
solve("herbs", "sugar");
solve("sugar", "solt");