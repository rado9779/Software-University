function attachEvents() {

    const urls = {
        allCatchesURL: 'https://fisher-game.firebaseio.com/catches.json',
        updateAndDeleteCatchURL: 'https://fisher-game.firebaseio.com/catches'
    };

    const loadButton = document.getElementsByClassName('load')[0];
    const addButton = document.getElementsByClassName('add')[0];
    const catches = document.getElementById('catches');
    const anglerInput = document.querySelector('#addForm > .angler');
    const weightInput = document.querySelector('#addForm > .weight');
    const speciesInput = document.querySelector('#addForm > .species');
    const locationInput = document.querySelector('#addForm > .location');
    const baitInput = document.querySelector('#addForm > .bait');
    const captureTimeInput = document.querySelector('#addForm > .captureTime');

    loadButton.addEventListener('click', loadCatches);
    addButton.addEventListener('click', createNewCatch);

    async function loadCatches() {
        await fetch(urls.allCatchesURL)
            .then((response) => renderResponse(response))
            .then((data) => listAllCatches(data))
            .catch(() => showError());
    }

    function listAllCatches(data) {

        catches.innerHTML = '';

        const catchesData = Object.entries(data);

        for (const [key, value] of catchesData) {

            const div = document.createElement('div');
            div.className = 'catch';
            div.setAttribute('data-id', key);

            //Angler
            const anglerLabel = createLabel('Angler');
            div.appendChild(anglerLabel);

            const anglerInput = createInput('text', 'angler', value.angler);
            div.appendChild(anglerInput);

            const hr1 = document.createElement('hr');
            div.appendChild(hr1);

            //Weight
            const weightLabel = createLabel('Weight');
            div.appendChild(weightLabel);

            const weightInput = createInput('number', 'weight', value.weight);
            div.appendChild(weightInput);

            const hr2 = document.createElement('hr');
            div.appendChild(hr2);

            //Species
            const speciesLabel = createLabel('Species');
            div.appendChild(speciesLabel);

            const speciesInput = createInput('text', 'species', value.species);
            div.appendChild(speciesInput);

            const hr3 = document.createElement('hr');
            div.appendChild(hr3);

            //Location
            const locationLabel = createLabel('Location');
            div.appendChild(locationLabel);

            const locationInput = createInput('text', 'location', value.location);
            div.appendChild(locationInput);

            const hr4 = document.createElement('hr');
            div.appendChild(hr4);

            //Bait
            const baitLabel = createLabel('Bait');
            div.appendChild(baitLabel);

            const baitInput = createInput('text', 'bait', value.bait);
            div.appendChild(baitInput);

            const hr5 = document.createElement('hr');
            div.appendChild(hr5);

            //Capture Time
            const captureTimeLabel = createLabel('Capture Time');
            div.appendChild(captureTimeLabel);

            const captureTimeInput = createInput('number', 'captureTime', value.captureTime);
            div.appendChild(captureTimeInput);

            const hr6 = document.createElement('hr');
            div.appendChild(hr6);

            //Update Button
            const updateButton = createButton('update', 'Update');
            updateButton.addEventListener('click', () => updateCatch(key));
            div.appendChild(updateButton);

            //Delete Button
            const deleteButton = createButton('delete', 'Delete');
            deleteButton.addEventListener('click', () => deleteCatch(key));
            div.appendChild(deleteButton);

            catches.appendChild(div);
        }
    }

    async function createNewCatch() {

        if (anglerInput.value &&
            weightInput.value &&
            speciesInput.value &&
            locationInput.value &&
            baitInput.value &&
            captureTimeInput.value) {

            const input = {
                angler: anglerInput.value,
                weight: weightInput.value,
                species: speciesInput.value,
                location: locationInput.value,
                bait: baitInput.value,
                captureTime: captureTimeInput.value
            };

            const request = {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(input)
            }

            await fetch(urls.allCatchesURL, request)
                .then((response) => renderResponse(response))
                .then(() => loadCatches())
                .then(() => clearInput())
                .catch(() => showError());
        }
    }

    function createLabel(text) {
        const result = document.createElement('label');
        result.textContent = text;
        return result;
    }

    function createInput(type, className, value) {
        const result = document.createElement('input');
        result.type = type;
        result.className = className;
        result.value = value;
        return result;
    }

    function createButton(className, textContent) {
        const result = document.createElement('button');
        result.className = className;
        result.textContent = textContent;
        return result;
    }

    function renderResponse(response) {
        if (response.status === 200) {
            return response.json();
        }
        throw response;
    }

    function showError() {
        const div = document.createElement('div');
        div.className = 'error';
        div.textContent = 'Error!';
        div.style.textAlign = 'center';
        div.style.fontSize = '3em';

        const br = document.createElement('br');

        catches.appendChild(br)
        catches.appendChild(div);
    }

    function clearInput() {
        anglerInput.value = '';
        weightInput.value = '';
        speciesInput.value = '';
        locationInput.value = '';
        baitInput.value = '';
        captureTimeInput.value = '';
    }

    async function deleteCatch(catchId) {
        const request = { method: 'DELETE' };

        await fetch(`${urls.updateAndDeleteCatchURL}/${catchId}.json`, request)
            .then((response) => renderResponse(response))
            .then(() => loadCatches())
            .catch(() => showError);
    }

    async function updateCatch(catchId) {

        const currentDiv = document.querySelector(`div[data-id="${catchId}"]`);
        const angler = currentDiv.querySelector('input.angler').value;
        const weight = currentDiv.querySelector('input.weight').value;
        const species = currentDiv.querySelector('input.species').value;
        const location = currentDiv.querySelector('input.location').value;
        const bait = currentDiv.querySelector('input.bait').value;
        const captureTime = currentDiv.querySelector('input.captureTime').value;

        const input = {
            angler,
            weight,
            species,
            location,
            bait,
            captureTime
        };

        const request = {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(input)
        };

        await fetch(`${urls.updateAndDeleteCatchURL}/${catchId}.json`, request)
            .then((response) => renderResponse(response))
            .then(() => loadCatches())
            .catch(() => showError);
    }
}

attachEvents();