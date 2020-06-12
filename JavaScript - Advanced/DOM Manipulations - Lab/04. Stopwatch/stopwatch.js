function stopwatch() {

    const displayTime = document.getElementById('time');
    const startButton = document.getElementById('startBtn');
    const stopButton = document.getElementById('stopBtn');

    startButton.addEventListener('click', start);
    stopButton.addEventListener('click', stop);

    let time = null;

    function stop() {
        stopButton.disabled = true;
        startButton.disabled = false;
        clearInterval(time);
    }

    function start() {
        startButton.disabled = true;
        stopButton.disabled = false;

        let seconds = 0;
        time = setInterval(increase, 1000);
        displayTime.textContent = '00:00';

        function increase() {
            seconds++;
            let currentMinutes = ('0' + Math.floor(seconds / 60)).slice(-2);
            let currentSeconds = ('0' + seconds % 60).slice(-2);
            displayTime.textContent = `${currentMinutes}:${currentSeconds}`;
        }
    }
}