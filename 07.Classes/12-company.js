class Company {
    departments = {};

    addEmployee(name, salary, position, department) {
        let isValid = function(input) {
            if (input === '' || input === undefined || input === null) {
                return false;
            }
    
            return true;
        }

        if (!isValid(name) || !isValid(salary) || salary < 0 || !isValid(position) || !isValid(department)) {
            console.log('Invalid input!');

            return;
        }

        if (!this.departments[department]) {
            this.departments[department] = [];
        }

        const employee = { name, salary, position };
        this.departments[department].push(employee);
    }

    bestDepartment() {
        let bestDepartment;
        let bestAvgSalary = 0;

        for (const department in this.departments) {
            const avgSalary = this.departments[department].reduce((a, b) => a + b.salary, 0) / this.departments[department].length;

            if (avgSalary > bestAvgSalary) {
                bestAvgSalary = avgSalary.toFixed(2);
                bestDepartment = department;
            }

        }

        let result = `Best Department is: ${bestDepartment}\nAverage salary: ${bestAvgSalary}\n`;

        const sortedDepartment = this.departments[bestDepartment].sort((a, b) => (b.salary - a.salary || b.name.localeCompare(a.name)));
        
        sortedDepartment.forEach(employee => {
            result += `${employee.name} ${employee.salary} ${employee.position}\n`;
        });

        return result.trim();
    }    
}

let c = new Company();
c.addEmployee("Stamat", 2000, "engineer", "Construction");
c.addEmployee("Peter", 1500, "electrical engineer", "Construction");
c.addEmployee("Martin", 500, "cleaner", "Construction");
c.addEmployee("Stanley", 2000, "architect", "Construction");
c.addEmployee("Stamat", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Peter", 1000, "graphical designer", "Marketing");
c.addEmployee("George", 1350, "HR", "Human resources");
console.log(c.bestDepartment());