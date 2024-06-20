function solve(leftItem, rightItem) {
    let notProperlyEquipped = true;

    let result;

    if (leftItem === "sword" || rightItem === "sword") {
        if (leftItem === "shield" || rightItem === "shield") {
            result = "Path to the castle";
        } else {
            result = "Path to the forest";
        }
        notProperlyEquipped = false;
    } 

    if (leftItem === "map" || rightItem === "map") {        
        if (leftItem === "coins" || rightItem === "coins") {
            result = "Go to the town";
        } else {
            result = "Camp";
        }
        notProperlyEquipped = false;
    }

    if (notProperlyEquipped) {
        result = "Wander aimlessly";
    }

    console.log(result);
}

solve("sword", "shield");
solve("map", "coins");
solve("torch", "flower");
solve("sword", "pouch");
solve("map", "compass");