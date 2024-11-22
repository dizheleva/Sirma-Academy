(function createCompanyHierarchy() {
    class Employee {
        constructor(name, age) {
            if (new.target === Employee) {
                throw new Error('Can not initialize from Employee class');
            }
    
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }    
    
        work() {
            const task = this.tasks.shift();
            this.tasks.push(task);
            console.log(`${this.name} is going to ${task}.`);
        }

        setSalary(salary) {
            this.salary = salary;
        }
        
        getSalary() {
            return this.salary;
        }
    }
    
    class Junior extends Employee {
        constructor(name, age) {        
            super(name, age);
            this.tasks = ['start working', 'self check work', 'send work to supervisor', 'work and learn']
        }    
    }
    
    class Senior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks = ['work', 'help junior', 'work', 'work harder', 'check juniors work'];
        }    
    }
    
    class Manager extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks = ['start meeting', 'schedule tasks', 'explain tasks to employees', 'manage work'];
            this.bonus = 0.02 * this.tasks.length;
        }    
        
        getSalary() {
            return super.getSalary() + this.bonus * this.salary;
        }
    }
    
    return {Employee, Junior, Senior, Manager};
}())