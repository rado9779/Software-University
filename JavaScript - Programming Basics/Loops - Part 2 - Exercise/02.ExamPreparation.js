function tasksSolving(input) {
    
    let maxNegativeGrades = Number(input.shift());

    let grades = 0;
    let negativeGrades = 0;
    let resolvedTasks = 0;
    let lastProblem;

    while (true) {
        let command = input.shift();

        if (command == "Enough") {
            break;
        }
        
        let taskName = command;
        let taskGrade = Number(input.shift());
        
        grades += taskGrade;
        lastProblem = taskName;
        resolvedTasks++;
        
        if (taskGrade <= 4) {
            negativeGrades++;
            
            if (negativeGrades === maxNegativeGrades) {
                console.log(`You need a break, ${negativeGrades} poor grades.`);
                return;
            }
        }
    }

    let avgGrade = grades / resolvedTasks;

    console.log(`Average score: ${avgGrade.toFixed(2)}`);
    console.log(`Number of problems: ${resolvedTasks}`);
    console.log(`Last problem: ${lastProblem}`);
}
