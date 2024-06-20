function solve(percentage) {
    let grade;
    
    if (percentage <= 59) {
        grade = "F";
    } else if (percentage <= 69) {
        grade = "D";
    } else if (percentage <= 79) {
        grade = "C";
    } else if (percentage <= 89) {
        grade = "B";
    } else {
        grade = "A";
    }
        
    console.log(grade);
}

solve(95);
solve(82);
solve(76);
solve(65);
solve(45);