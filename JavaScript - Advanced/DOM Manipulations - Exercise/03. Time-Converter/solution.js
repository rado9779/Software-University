function attachEventsListeners() {

    const days = document.getElementById('days');
    const hours = document.getElementById('hours');
    const minutes = document.getElementById('minutes');
    const seconds = document.getElementById('seconds');

    const daysButton = document.getElementById('daysBtn');
    const hoursButton = document.getElementById('hoursBtn');
    const minutesButton = document.getElementById('minutesBtn');
    const secondsButton = document.getElementById('secondsBtn');

    daysButton.addEventListener('click', convertDays);
    hoursButton.addEventListener('click', convertHours);
    minutesButton.addEventListener('click', convertMinutes);
    secondsButton.addEventListener('click', convertSeconds);


    function convertDays(e) {
        const input = Number(days.value);
        hours.value = input * 24;
        minutes.value = input * 1440;
        seconds.value = input * 86400;
    }

    function convertHours(e) {
        const input = Number(hours.value);
        days.value = input / 24;
        minutes.value = input * 60;
        seconds.value = input * 3600;
    }

    function convertMinutes(e) {
        const input = Number(minutes.value);
        days.value = input / 1440;
        hours.value = input / 60;
        seconds.value = input * 60;
    }

    function convertSeconds(e) {
        const input = Number(seconds.value);
        minutes.value = input / 60;
        hours.value = input / 3600;
        days.value = input / 86400;
    }
}