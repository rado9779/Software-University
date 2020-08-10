function solve() {
    const container = document.getElementById('container');
    const inputName = container.getElementsByTagName('input')[0];
    const inputAge = container.getElementsByTagName('input')[1];
    const inputKind = container.getElementsByTagName('input')[2];
    const inputOwner = container.getElementsByTagName('input')[3];
    const addButton = container.getElementsByTagName('button')[0];
    const adoptionList = document.getElementById('adoption');
    const adoptedList = document.getElementById('adopted');

    addButton.addEventListener('click', (e) => {

        const name = inputName.value;
        const age = inputAge.value;
        const kind = inputKind.value;
        const owner = inputOwner.value;

        if (!name || isNaN(Number(age)) || !kind || !owner) {
            return;
        }

        fillAdoptedList(name, kind, owner, age);
        
        inputName.value = '';
        inputAge.value = '';
        inputKind.value = '';
        inputOwner.value = '';
        
        e.preventDefault();
    })
    
    function fillAdoptedList(name, kind, owner, age) {

        const ul = adoptionList.getElementsByTagName('ul')[0];
        const li = document.createElement('li');
        const p = document.createElement('p');
        const pContent = `<strong>${name}</strong> is a <strong>${age}</strong> year old <strong>${kind}</strong>`;
        p.innerHTML = pContent;
        const span = document.createElement('span');
        span.textContent = `Owner: ${owner}`;
        const ownerButton = document.createElement('button');
        ownerButton.textContent = 'Contact with owner';
        ownerButton.addEventListener('click', ownerButtonFunction);

        ul.appendChild(li);
        li.appendChild(p);
        li.appendChild(span);
        li.appendChild(ownerButton);
    }

    function ownerButtonFunction(e) {

        const ul = e.target.parentElement;
        const div = document.createElement('div');
        const input = document.createElement('input');

        input.placeholder = 'Enter your names';

        const takeButton = document.createElement('button');
        takeButton.textContent = 'Yes! I take it!';
        takeButton.addEventListener('click', takeButtonFunction);
        
        div.appendChild(input);
        div.appendChild(takeButton)
        ul.appendChild(div);
        
        e.target.remove();
    }

    function takeButtonFunction(e) {
        const owner = e.target.previousElementSibling.value;

        if (owner) {
            const li = e.target.parentElement.parentElement;

            li.lastElementChild.remove();
            li.getElementsByTagName('span')[0].remove();

            const span = document.createElement('span');
            span.textContent = `New Owner: ${owner}`;
            li.appendChild(span);

            const checkButton = document.createElement('button');
            checkButton.textContent = 'Checked';
            checkButton.addEventListener('click', checkButtonFunction);
            li.appendChild(checkButton);

            const ul = document.querySelector("#adopted > ul");
            ul.appendChild(li);
            adoptedList.appendChild(ul);
        }
    }

    function checkButtonFunction(e) {
        e.target.parentElement.remove();
    }
}

