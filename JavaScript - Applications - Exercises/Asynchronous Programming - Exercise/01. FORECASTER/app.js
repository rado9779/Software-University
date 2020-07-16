function attachEvents() {

    const urls = {
        locationsURL: 'https://judgetests.firebaseio.com/locations.json',
        currentConditionsURL: 'https://judgetests.firebaseio.com/forecast/today',
        threeDaysForecastURL: 'https://judgetests.firebaseio.com/forecast/upcoming'
    };

    const symbols = {
        'Sunny': '☀',
        'Partly sunny': '⛅',
        'Overcast': '☁',
        'Rain': '☂',
        'Degrees': '°'
    };

    const content = document.getElementById('content');
    const locationInput = document.getElementById('location');
    const getWeatherButton = document.getElementById('submit');
    const forecastSection = document.getElementById('forecast');
    const currentConditionsDiv = document.getElementById('current');
    const upcomingConditionsDiv = document.getElementById('upcoming');

    getWeatherButton.addEventListener('click', getWeather);
    
    function getWeather() {
        
        fetch(urls.locationsURL)
        .then((response) => renderResponse(response))
        .then((data) => getWeatherData(data))
        .catch(() => showError());

    }
    
    function getWeatherData(data) {
        
        const location = data.find(x => x.name === locationInput.value);
        if (location.code !== null) {
            forecastSection.style.display = 'block';
            getCurrentConditions(location.code);
            getThreeDaysForecast(location.code);
        }
        else{
            showError();
        }
    }
    
    function getCurrentConditions(code) {
        
        fetch(`${urls.currentConditionsURL}/${code}.json`)
        .then((response) => renderResponse(response))
        .then((data) => getConditions(data))
        .catch(() => showError());
    }
    
    function getConditions(data) {

        const div = document.createElement('div');
        div.className = 'forecasts';
        currentConditionsDiv.appendChild(div);
        
        const conditionSymbolSpan = document.createElement('span');
        conditionSymbolSpan.className = 'condition symbol';
        conditionSymbolSpan.textContent = symbols[data.forecast.condition];
        div.appendChild(conditionSymbolSpan);
        
        const conditionSpan = document.createElement('span');
        conditionSpan.className = 'condition';
        div.appendChild(conditionSpan);
        
        const citySpan = document.createElement('span');
        citySpan.className = 'forecast-data';
        citySpan.textContent = data.name;
        conditionSpan.appendChild(citySpan);
        
        const temperaturesSpan = document.createElement('span');
        temperaturesSpan.className = 'forecast-data';
        temperaturesSpan.textContent = `${data.forecast.low}°/${data.forecast.high}°`;
        conditionSpan.appendChild(temperaturesSpan);
        
        const weatherTypeSpan = document.createElement('span');
        weatherTypeSpan.className = 'forecast-data';
        weatherTypeSpan.textContent = data.forecast.condition;
        conditionSpan.appendChild(weatherTypeSpan);
    }
    
    function getThreeDaysForecast(code) {
        
        fetch(`${urls.threeDaysForecastURL}/${code}.json`)
        .then((response) => renderResponse(response))
        .then((data) => getForecast(data))
        .catch(() => showError());
    }
    
    function getForecast(data) {
        
        const div = document.createElement('div');
        div.className = 'forecast-info';
        upcomingConditionsDiv.appendChild(div);
        
        data.forecast.forEach(array => {
            const upcomingSpan = document.createElement('span');
            upcomingSpan.className = 'upcoming';
            div.appendChild(upcomingSpan);
            
            const symbolSpan = document.createElement('span');
            symbolSpan.className = 'symbol';
            symbolSpan.textContent = symbols[array.condition];
            upcomingSpan.appendChild(symbolSpan);
            
            const temperaturesSpan = document.createElement('span');
            temperaturesSpan.className = 'forecast-data';
            temperaturesSpan.textContent = `${array.low}°/${array.high}°`;
            upcomingSpan.appendChild(temperaturesSpan);
            
            const weatherType = document.createElement('span');
            weatherType.className = 'forecast-data';
            weatherType.textContent = array.condition;
            upcomingSpan.appendChild(weatherType);

            locationInput.value = '';
        });
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
        div.style.backgroundColor = 'aquamarine';

        const br = document.createElement('br');

        content.appendChild(br)
        content.appendChild(div);
    }
}

attachEvents();