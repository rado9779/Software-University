function solve() {

    const addContainer = document.getElementById('container');
    const inputName = addContainer.getElementsByTagName('input')[0];
    const inputHall = addContainer.getElementsByTagName('input')[1];
    const ticketPrice = addContainer.getElementsByTagName('input')[2];
    const addButton = addContainer.getElementsByTagName('button')[0];
    const movies = document.getElementById('movies');
    const ul = movies.getElementsByTagName('ul')[0];
    const archive = document.getElementById('archive');
    const archiveUL = archive.getElementsByTagName('ul')[0];
    const clearButton = archive.getElementsByTagName('button')[0];

    addButton.addEventListener('click', addFunction);
    clearButton.addEventListener('click', clear);

    function addFunction(e) {
        e.preventDefault();

        const name = inputName.value;
        const hall = inputHall.value;
        const price = ticketPrice.value;

        if (!name || isNaN(Number(price)) || !hall || !price) {
            return;
        }

        const li = document.createElement('li');
        const titleSpan = document.createElement('span');
        titleSpan.textContent = name;
        const hallStrong = document.createElement('strong');
        hallStrong.textContent = hall;
        const div = document.createElement('div');
        const priceStrong = document.createElement('strong');
        priceStrong.textContent = price;
        const input = document.createElement('input');
        input.placeholder = 'Tickets Sold';
        const archiveButton = document.createElement('button');
        archiveButton.textContent = 'Archive';
        archiveButton.addEventListener('click', archiveFunction);

        li.appendChild(titleSpan);
        li.appendChild(hallStrong);
        div.appendChild(priceStrong);
        div.appendChild(input);
        div.appendChild(archiveButton);
        li.appendChild(div);
        ul.appendChild(li);

        inputName.value = '';
        inputHall.value = '';
        ticketPrice.value = ''
    }

    function archiveFunction(e) {

        const tickets = e.target.previousElementSibling.value;
        const toDelete = e.target.parentElement.parentElement;
        const price = e.target.parentElement.firstElementChild.textContent;
        toDelete.remove();

        if (isNaN(tickets) || !tickets) {
            return;
        }

        const movie = e.target.parentElement.parentElement.firstElementChild.textContent;
        const li = document.createElement('li');
        const span = document.createElement('span');
        span.textContent = movie;
        const strong = document.createElement('strong');
        strong.textContent = `Total amount: ${(tickets * price).toFixed(2)}`;
        const deleteButton = document.createElement('button');
        deleteButton.textContent = 'Delete';
        deleteButton.addEventListener('click', deleteFunction);

        li.appendChild(span);
        li.appendChild(strong);
        li.appendChild(deleteButton);
        archiveUL.appendChild(li);
    }

    function deleteFunction(e) {
        e.target.parentElement.remove();
    }

    function clear() {
        archiveUL.innerHTML = '';
    }
}