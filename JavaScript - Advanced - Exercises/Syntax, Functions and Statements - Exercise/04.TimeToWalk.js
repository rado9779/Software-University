function timeToUniversity(studentSteps, footprintInMeters, studentSpeed) {

    let steps = Number(studentSteps);
    let footPrint = Number(footprintInMeters);
    let speed = Number(studentSpeed);

    let distance = steps * footPrint;
    let time = Math.round(distance / speed * 3.6);
    let rests = Math.floor(distance / 500) * 60;
    let totalTime = time + rests;

    let seconds = totalTime % 60;
    totalTime -= seconds;
    totalTime /= 60;

    let minutes = totalTime % 60;
    totalTime -= minutes;
    totalTime /= 60;

    console.log((totalTime < 10 ? "0" : "") + totalTime + ":" + (minutes < 10 ? "0" : "") + (minutes) + ":" + (seconds < 10 ? "0" : "") + seconds);
}
