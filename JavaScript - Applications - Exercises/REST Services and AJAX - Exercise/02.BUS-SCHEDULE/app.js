function solve() {

    const info = document.getElementsByTagName('span')[0];
    const departButton = document.getElementById('depart');
    const arriveButton = document.getElementById('arrive');
    let currentId = 'depot';

    function depart() {
        const url = `https://judgetests.firebaseio.com/schedule/${currentId}.json`;

        fetch(url)
            .then((response) => response.json())
            .then((data) => showInfo(data))
            .catch(() => showError());

        function showInfo(data) {
            departButton.disabled = true;
            arriveButton.disabled = false;
            info.textContent = `Next stop ${data.name}`;
        }
    }

    function arrive() {
        const url = `https://judgetests.firebaseio.com/schedule/${currentId}.json`;

        fetch(url)
            .then((response) => response.json())
            .then((data) => showInfo(data))
            .catch(() => showError());

        function showInfo(data) {
            arriveButton.disabled = true;
            departButton.disabled = false;
            info.textContent = `Arriving at ${data.name}`;
            currentId = data.next;
        }
    }

    function showError() {
        info.textContent = 'Error';
        arriveButton.disabled = true;
        departButton.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();