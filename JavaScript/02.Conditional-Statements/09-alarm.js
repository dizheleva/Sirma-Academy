function solve(hours, minutes) {

    if (minutes + 15 >= 60) {
        minutes = (minutes + 15) % 60; 
        hours ++;

        if (hours >= 24) {
            hours = hours % 24; 
        }
    } else {
        minutes = minutes + 15;
    }

    console.log(hours + ":" + minutes.toString().padStart(2, 0));
}

solve(1, 47);
solve(0, 2);
solve(23, 59);
solve(11, 7);
solve(12, 48);