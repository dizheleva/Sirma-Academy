function solution(totalWater, people) {  
    let dailyPerPerson = totalWater / (7 * people);

    console.log(dailyPerPerson.toFixed(2));
}

solution(2450, 7);
solution(3150, 10);
solution(980, 7);