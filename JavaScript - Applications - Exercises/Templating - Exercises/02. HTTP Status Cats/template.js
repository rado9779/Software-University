(() => {
    renderCatTemplate();

    function onClick(e) {

        if (e.target.className !== 'showBtn') {
            return;
        }

        const div = e.target.parentNode.querySelector('.status');

        if (div.style.display === 'none') {
            div.style.display = 'block';
            e.target.textContent = 'Hide status code';
        }
        else {
            div.style.display = 'none';
            e.target.textContent = 'Show status code';
        }
    }

    async function renderCatTemplate() {

        const allCats = document.getElementById('allCats');

        await fetch('./catsTemplate.hbs')
            .then(resources => resources.text())
            .then((data) => {
                const cats = window.cats;
                const template = Handlebars.compile(data);
                allCats.addEventListener('click', onClick);
            })
    }
})();
