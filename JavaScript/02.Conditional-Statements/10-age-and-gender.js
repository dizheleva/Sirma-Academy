function solve(age, gender) {
    if (gender === "f") {
        if (age <= 16) {
            console.log("Miss");
        } else {
            console.log("Ms.");
        }
    } else {
        if (age <= 16) {
            console.log("Master");
        } else {
            console.log("Mr.");
        }
    }
}

solve(14, "f");
solve(17, "m");
solve(10, "m");
solve(32, "f");