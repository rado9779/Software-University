function timeAfter15Minutes(inputHours,inputMinutes){

    let hour = Number(inputHours);
    let minutes = Number(inputMinutes);

    let hourInMinutes = hour * 60;
    let timeSum = hourInMinutes + minutes + 15;

    let resultHours = Math.floor(timeSum / 60);

    if (resultHours == 24) {
        resultHours = 0;
    }

    let resultMinutes = timeSum % 60;

    if (resultMinutes < 9) {
        console.log(`${resultHours}:0${resultMinutes}`)
    }
    else{
        console.log(`${resultHours}:${resultMinutes}`)
    }
}

