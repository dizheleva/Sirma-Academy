function solve(month) {
    let days;

    switch (month) {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            days = 31;
            break;
        case 2:
            days = 28;
            break;
        default:
            days = 30;
            break;
    }
    

    console.log(days);
}

solve(1);
solve(2);
solve(4);
solve(7);