class Student {
    constructor(name, grade, score) {
        this.name = name;
        this.grade = grade;
        this.score = score;
    }
}

class SchoolBook {
    #register = {};

    addStudent(student) {
        if (student.score < 3) {
            return;
        }

        student.grade++;
       
        const grade = student.grade;
        if (!this.#register[grade]) {
            this.#register[grade] = [];
        }

        this.#register[grade].push(student);
    }

    printRegister() {
        for (const grade in this.#register) {
            const students = this.#register[grade];

            const studentNames = students
                .map(student => student.name)
                .join(', ');
            const totalScore = students
                .reduce((totalScore, student) => totalScore + student.score, 0);
            const averageScore = totalScore / students.length;

            console.log(`${grade} Grade`);
            console.log(`List of students: ${studentNames}`);
            console.log(`Average annual score from last year: ${averageScore.toFixed(2)}`);
            console.log('===');
        }
    }
}

function solve(input) {
    const schoolBook = new SchoolBook();

    for (const line of input) {
        let studentInfo = line.split(', ');
        let name = studentInfo[0].split(': ')[1];
        let grade = Number(studentInfo[1].split(': ')[1]);
        let score = Number(studentInfo[2].split(': ')[1]);

        const student = new Student(name, grade, score);

        schoolBook.addStudent(student);
    }

    schoolBook.printRegister();
}


solve([
    "Student name: Mark, Grade: 8, Graduated with an average score: 4.75",
    "Student name: Ethan, Grade: 9, Graduated with an average score: 5.66",
    "Student name: George, Grade: 8, Graduated with an average score: 2.83",
    "Student name: Steven, Grade: 10, Graduated with an average score: 4.20",
    "Student name: Joey, Grade: 9, Graduated with an average score: 4.90",
    "Student name: Angus, Grade: 11, Graduated with an average score: 2.90",
    "Student name: Bob, Grade: 11, Graduated with an average score: 5.15",
    "Student name: Daryl, Grade: 8, Graduated with an average score: 5.95",
    "Student name: Bill, Grade: 9, Graduated with an average score: 6.00",
    "Student name: Philip, Grade: 10, Graduated with an average score: 5.05",
    "Student name: Peter, Grade: 11, Graduated with an average score: 4.88",
    "Student name: Gavin, Grade: 10, Graduated with an average score: 4.00"
]);
solve([
    "Student name: George, Grade: 5, Graduated with an average score: 2.75",
    "Student name: Alex, Grade: 9, Graduated with an average score: 3.66",
    "Student name: Peter, Grade: 8, Graduated with an average score: 2.83",
    "Student name: Boby, Grade: 5, Graduated with an average score: 4.20",
    "Student name: John, Grade: 9, Graduated with an average score: 2.90",
    "Student name: Steven, Grade: 2, Graduated with an average score: 4.90",
    "Student name: Darsy, Grade: 1, Graduated with an average score: 5.15"
]);