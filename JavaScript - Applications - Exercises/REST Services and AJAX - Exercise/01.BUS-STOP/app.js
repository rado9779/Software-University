function getInfo() {

    const stopId = document.getElementById('stopId').value;
    const url = `https://judgetests.firebaseio.com/businfo/${stopId}.json `;
    const stopName = document.getElementById('stopName');
    const buses = document.getElementById('buses');
    
    stopName.textContent = '';
    buses.textContent = '';

    fetch(url)
        .then((response) => response.json())
        .then((data) => showInfo(data))
        .catch(() => stopName.textContent = 'Error');

    function showInfo(data) {
        stopName.textContent = data.name;
        const busesData = Object.keys(data.buses);

        busesData.forEach((busId, time) => {
            const li = document.createElement('li');
            li.textContent = `Bus ${busId} arrives in ${time}`;
            buses.appendChild(li);
        });
    };
}