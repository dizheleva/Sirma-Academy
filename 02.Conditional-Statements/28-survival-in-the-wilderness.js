function solve(time, environment, item) {
    let action = "No action";

    if (time === "day") {
        if (environment === "forest") {
            if (item === "knife") {
                action = "Hunt for food";
            } else if (item === "container") {
                action = "Collect berries";
            } else {
                action = "Explore";
            }
        } else if (environment === "desert") {
            if (item === "hat") {
                action = "Search for water";
            } else {
                action = "Find shade";
            }
        }
    } else if (time === "night") {
        if (environment === "forest") {
            if (item === "firestarter") {
                action = "Make a campfire";
            } else {
                action = "Climb a tree for safety";
            }
        } else if (environment === "desert") {
            if (item === "blanket") {
                action = "Sleep";
            } else {
                action = "Keep moving to stay warm";
            }
        } 
    }
    
    console.log(action);
}

solve("day", "forest", "knife");
solve("day", "forest", "container");
solve("night", "forest", "firestarter");
solve("day", "forest", "bag");
solve("night", "desert", "blanket");
solve("day", "desert", "hat");
solve("night", "desert", "sword");
solve("night", "forest", "hat");