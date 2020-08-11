function solve() {

    const inputTask = document.getElementById('task');
    const inputDescription = document.getElementById('description');
    const inputDate = document.getElementById('date');
    const addButton = document.getElementById('add');
    const openSection = document.getElementsByTagName('section')[1].lastElementChild;
    const inProgressSection = document.getElementById('in-progress');
    const completeSection = document.getElementsByTagName('section')[3].lastElementChild;

    addButton.addEventListener('click', onClick);

    function onClick(e) {

        e.preventDefault();

        const task = inputTask.value;
        const description = inputDescription.value;
        const date = inputDate.value;

        if (!task || !description || !date) {
            return;
        }

        const article = document.createElement('article');
        const h3 = document.createElement('h3');
        h3.textContent = task;
        const descriptionParagraph = document.createElement('p');
        descriptionParagraph.textContent = `Description: ${description}`;
        const dataParagraph = document.createElement('p');
        dataParagraph.textContent = `Due Date: ${date}`;
        const div = document.createElement('div');
        div.className = 'flex';
        const startBtn = document.createElement('button');
        startBtn.textContent = 'Start';
        startBtn.className = 'green';
        startBtn.addEventListener('click', startFunction);
        const deleteBtn = document.createElement('button');
        deleteBtn.textContent = 'Delete';
        deleteBtn.className = 'red';
        deleteBtn.addEventListener('click', deleteFunction);

        openSection.appendChild(article);
        article.appendChild(h3);
        article.appendChild(descriptionParagraph);
        article.appendChild(dataParagraph);
        article.appendChild(div);
        div.appendChild(startBtn);
        div.appendChild(deleteBtn);

        inputTask.value = '';
        inputDescription.value = '';
        inputDate.value = '';
    }

    function startFunction(e) {
        const article = e.target.parentElement.parentElement;
        const div = e.target.parentElement;
        article.getElementsByClassName('green')[0].remove();

        const finishBtn = document.createElement('button');
        finishBtn.className = 'orange';
        finishBtn.textContent = 'Finish';
        finishBtn.addEventListener('click', finishFunction);

        div.appendChild(finishBtn);
        inProgressSection.appendChild(article);
    }

    function deleteFunction(e) {
        const article = e.target.parentElement.parentElement.remove();
    }

    function finishFunction(e) {
        const article = e.target.parentElement.parentElement;
        article.getElementsByClassName('flex')[0].remove();
        completeSection.appendChild(article);
    }
}