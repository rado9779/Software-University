async function attachEvents() {

    const input = document.getElementById('towns');
    const townsResult = document.getElementById('root');

    if (input.value) {
        await fetch('./townTemplate.hbs')
            .then(resources => resources.text())
            .then((data) => {
                const towns = input.value.split(', ');
                const template = Handlebars.compile(data);
                townsResult.innerHTML = template({ towns });
                input.value = '';
            })
    }
}