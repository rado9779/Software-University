function attachEventsListeners() {

    const button = document.getElementById('convert');
    const input = document.getElementById('inputDistance');
    const outputDistance = document.getElementById('outputDistance');
    const inputType = document.getElementById('inputUnits');
    const outputType = document.getElementById('outputUnits');

    button.addEventListener('click', Convert);

    function Convert() {

        let inputDistance = Number(input.value);
        let inputUnits = inputType.value;
        let outputUnits = outputType.value;

        let value = 0;
        let result = 0;

        switch (inputUnits) {
            case 'km':
                value = inputDistance * 1000;
                break;
            case 'm':
                value = inputDistance;
                break;
            case 'cm':
                value = inputDistance * 0.01;
                break;
            case 'mm':
                value = inputDistance * 0.001;
                break;
            case 'mi':
                value = inputDistance * 1609.34;
                break;
            case 'yrd':
                value = inputDistance * 0.9144;
                break;
            case 'ft':
                value = inputDistance * 0.3048;
                break;
            case 'in':
                value = inputDistance * 0.0254;
                break;
        }

        switch (outputUnits) {
            case 'km':
                result = value / 1000;
                break;
            case 'm':
                result = value;
                break;
            case 'cm':
                result = value / 0.01;
                break;
            case 'mm':
                result = value / 0.001;
                break;
            case 'mi':
                result = value / 1609.34;
                break;
            case 'yrd':
                result = value / 0.9144;
                break;
            case 'ft':
                result = value / 0.3048;
                break;
            case 'in':
                result = value / 0.0254;
                break;
        }

        outputDistance.value = result;
    }
}