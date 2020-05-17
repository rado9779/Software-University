function averageGrade(input) {

    let studentName = input.shift();

    let counter = 0;
    let grades = 0.0;

    while (counter != 12) {

        let grade = Number(input.shift());

        if (grade < 4.00) {
            continue;
        }
        else {
            grades += grade;
        }
        counter++;
    }

    let averageGrade = grades / 12;

    if (averageGrade > 4.00) {
        console.log(`${studentName} graduated. Average grade: ${averageGrade.toFixed(2)}`);
    }
}

