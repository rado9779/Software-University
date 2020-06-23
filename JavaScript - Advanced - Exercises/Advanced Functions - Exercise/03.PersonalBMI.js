function solution(name, age, weight, height) {

    let BMI = Math.round(weight / Math.pow(height / 100, 2));
    let status;

    let personalInfo = {
        age: age,
        weight: weight,
        height: height
    };

    let person = {
        name: name,
        personalInfo: personalInfo,
        BMI: BMI,
        status: status
    };

    if (BMI < 18.5) {
        person.status = 'underweight';
    }
    else if (BMI < 25) {
        person.status = 'normal';
    }
    else if (BMI < 30) {
        person.status = 'overweight';
    }
    else if (BMI >= 30) {
        person.status = 'obese';
        person.recommendation = 'admission required';
    }

    return person;
}