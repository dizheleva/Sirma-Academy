function solve(number) {
    const daysOfWeek = [
        'Monday',
        'Tuesday',
        'Wednesday',
        'Thursday',
        'Friday',
        'Saturday',
        'Sunday',
    ];

    if (daysOfWeek[number - 1]) {
        console.log(daysOfWeek[number - 1]);
    } else {
        console.log('Invalid Day!');
    }
}

solve(3);
solve(6);
solve(11);