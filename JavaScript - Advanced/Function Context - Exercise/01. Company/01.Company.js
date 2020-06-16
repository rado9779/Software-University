class Company {

    constructor() {
        this.departments = [];
    }

    addEmployee(username, salary, position, department) {

        this.isValid(username);
        this.isValid(salary);
        this.isValid(position);
        this.isValid(department);

        if (salary < 0) {
            throw Error('Invalid input!')
        }

        let current = this.departments.find(d => d.name === department);

        if (current === undefined) {
            current = {
                name: department,
                employees: []
            };

            this.departments.push(current)
        }

        current.employees.push({
            username,
            salary,
            position
        })

        return `New employee is hired. Name: ${username}. Position: ${position}`;
    }

    bestDepartment() {
        const departments = this.departments.map(x => {
            const department = Object.assign({}, x);
            department.averageSalary = x.employees.reduce((p, c, i, a) =>
                p + c.salary, 0) / x.employees.length;
            return department;
        });

        departments.sort((a, b) => b.averageSalary - a.averageSalary);

        const best = departments[0];
        
        if (best !== undefined) {
            best.employees.sort((a, b) => b.salary - a.salary || a.username.localeCompare(b.username));

            const result = [
                `Best Department is: ${best.name}`,
                `Average salary: ${best.averageSalary.toFixed(2)}`
            ];

            best.employees.forEach(e => result.push(`${e.username} ${e.salary} ${e.position}`))
            return result.join('\n')
        }
    }

    isValid(input) {
        if (input === '' || input === undefined || input === null) {
            throw Error('Invalid input!');
        }
    }
}