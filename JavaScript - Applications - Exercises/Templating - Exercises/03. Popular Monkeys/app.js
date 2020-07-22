import monkeys from './monkeys.js';
const monkeysDiv = document.getElementsByClassName('monkeys')[0];

fetch('./template.hbs')
.then(resources => resources.text())
.then((data) => {
    const template = Handlebars.compile(data);
    monkeysDiv.innerHTML = template({monkeys});
    monkeysDiv.addEventListener('click',onClick)
});

function onClick(e) {
    if (e.target.tagName !== 'BUTTON') {
        return;
    }

    const div = e.target.parentNode.querySelector('p');

    if (div.style.display === 'none') {
        div.style.display = 'block';
        e.target.textContent = 'Hide INFO';
    }
    else {
        div.style.display = 'none';
        e.target.textContent = 'INFO';
    }
}