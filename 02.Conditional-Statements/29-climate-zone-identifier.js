function solve(latitude, hemisphere) {
    latitude = Math.abs(latitude);
    
    let zone;

    if (latitude === 0) {
        zone = "Equator";
    } else if (latitude <= 23.5) {
        zone = "Tropic Zone";
    } else if (latitude <= 66.5) {
        zone = "Temperate Zone";
    } else {
        zone = "Arctic Zone";       
    } 
        
    console.log(zone);
}

solve(70, "N");
solve(45, "S");
solve(10, "N");
solve(0, "N");
solve(-85, "S");