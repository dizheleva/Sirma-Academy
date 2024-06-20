function solve(score, extracurriculars) {
    let result;

    if (score >= 90 || (score >= 80 && extracurriculars >= 2)) {
        result = "Admitted";
    } else {
        result = "Not admitted";        
    } 
        
    console.log(result);
}

solve(85, 3);
solve(88, 1);
solve(91, 0);
solve(75, 12);