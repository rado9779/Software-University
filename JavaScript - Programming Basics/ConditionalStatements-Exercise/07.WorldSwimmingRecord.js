function swimmingTime(recordInput, distanceInput, timeInput){

    let record = Number(recordInput);
    let distance = Number(distanceInput);
    let time = Number(timeInput);

    let swimmerTime = distance * time;
    let waterResistance = Math.floor (distance / 15).toFixed(0) * 12.5;

    let finalTime = swimmerTime + waterResistance;

    let difference = Math.abs(finalTime - record)

    if (record > finalTime){
        console.log(`Yes, he succeeded! The new world record is ${finalTime.toFixed(2)} seconds.`);
    }
    else {
        console.log(`No, he failed! He was ${difference.toFixed(2)} seconds slower.`);
    }
}