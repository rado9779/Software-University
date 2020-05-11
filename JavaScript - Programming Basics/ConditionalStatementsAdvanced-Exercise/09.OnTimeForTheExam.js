function studentArrival(startHour, startMinutes, arriveHour, arriveMinutes) {

    let examHour = Number(startHour);
    let examMinutes = Number(startMinutes);
    let studentHour = Number(arriveHour);
    let studentMinutes = Number(arriveMinutes);

    let examInMinutes = (examHour * 60) + examMinutes;
    let studentInMinutes = (studentHour * 60) + studentMinutes;

    let hours = 0;
    let minutes = 0;
    let leftMinutes = 0;

    if (studentInMinutes > examInMinutes) {
        console.log("Late");
        leftMinutes = studentInMinutes - examInMinutes;

        if (leftMinutes / 60 > 0) {
            hours = Math.floor(leftMinutes / 60);
        }
        minutes = leftMinutes % 60;

        if (hours <= 0) {
            console.log(`${minutes} minutes after the start`);
        }
        else if (hours > 0 && minutes <= 9) {
            console.log(`${hours}:0${minutes} hours after the start`);
        }
        else {
            console.log(`${hours}:${minutes} hours after the start`);
        }
    }
    else if (studentInMinutes == examInMinutes || (examInMinutes - studentInMinutes) <= 30) {
        console.log("On time");
        leftMinutes = examInMinutes - studentInMinutes;

        if (leftMinutes > 0) {
            console.log(`${leftMinutes} minutes before the start`);
        }
    }
    else if (examInMinutes - studentInMinutes > 30) {
        console.log("Early");
        leftMinutes = examInMinutes - studentInMinutes;

        if (leftMinutes / 60 > 0) {
            hours = Math.floor(leftMinutes / 60);
        }
        minutes = leftMinutes % 60;

        if (hours <= 0) {
            console.log(`${minutes} minutes before the start`);
        }
        else if (hours > 0 && minutes <= 9) {
            console.log(`${hours}:0${minutes} hours before the start`);
        }
        else {
            console.log(`${hours}:${minutes} hours before the start`);
        }
    }
}



