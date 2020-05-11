function studentScholarship(parentIncome,schoolPerformance,minSalary){

    let income = Number(parentIncome);
    let performance = Number(schoolPerformance);
    let salary = Number(minSalary);

    let socialScholarship = 0;

    if (income < salary && performance > 4.5) {
        socialScholarship = salary * 0.35;
    }

    let excellentScholarship = 0;

    if (performance >= 5.5) {
        excellentScholarship = performance * 25;
    }

    if (socialScholarship == 0 && excellentScholarship == 0) {
        console.log("You cannot get a scholarship!");
    }
    
    if (socialScholarship != 0 && socialScholarship > excellentScholarship) {
        console.log(`You get a Social scholarship ${Math.floor(socialScholarship)} BGN`);
    }

    if (excellentScholarship != 0 && excellentScholarship >= socialScholarship) {
        console.log(`You get a scholarship for excellent results ${Math.floor(excellentScholarship)} BGN`);
    }
}
