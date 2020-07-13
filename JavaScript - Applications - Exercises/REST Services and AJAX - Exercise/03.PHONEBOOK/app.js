function attachEvents() {

    const deleteAndPostRequestURL = `http://localhost:8000/phonebook`;

    //Load
    const loadButton = document.getElementById('btnLoad');
    const phonebook = document.getElementById('phonebook');
    loadButton.addEventListener('click', loadPhonebookContacts);

    function loadPhonebookContacts() {

        phonebook.innerHTML = '';

        fetch(deleteAndPostRequestURL)
            .then((response) => response.json())
            .then((data) => loadContacts(data));

        function loadContacts(data) {
            const contacts = Object.keys(data);

            contacts.forEach((id) => {
                const li = document.createElement('li');
                li.textContent = `${data[id].person}: ${data[id].phone}`;
                const deleteButton = document.createElement("button");
                deleteButton.textContent = "Delete";
                deleteButton.addEventListener("click", () => deleteContact(id));
                li.appendChild(deleteButton);
                phonebook.appendChild(li);
            });
        }
    }

    //Create
    const createButton = document.getElementById('btnCreate');
    createButton.addEventListener('click', createContact);

    function createContact() {

        const name = document.getElementById('person').value;
        const phoneNumber = document.getElementById('phone').value;
        const personInfo = { person: name, phone: phoneNumber };
        const createRequest = { method: 'POST', body: JSON.stringify(personInfo) };

        fetch(deleteAndPostRequestURL, createRequest)
            .then((response) => response.json())
            .then(() => loadPhonebookContacts())
            .catch(() => console.log('Error'));

        document.getElementById('person').value = '';
        document.getElementById('phone').value = '';
    }

    //Delete
    function deleteContact(id) {
        const deleteRequestURL = `http://localhost:8000/phonebook/${id}`;
        const deleteRequest = { method: 'DELETE' };
        
        fetch(deleteRequestURL, deleteRequest)
            .then(() => loadPhonebookContacts())
            .catch(() => console.log('Error'));
    }
}

attachEvents();