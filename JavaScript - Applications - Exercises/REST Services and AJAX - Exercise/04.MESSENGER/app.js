function attachEvents() {

    const messagesContainer = document.getElementById('messages');
    const author = document.getElementById('author');
    const message = document.getElementById('content');
    const submitButton = document.getElementById('submit');
    const refreshButton = document.getElementById('refresh');

    const url = `http://localhost:8000/messenger`;

    submitButton.addEventListener('click', send);
    refreshButton.addEventListener('click', refresh);

    function send() {

        const user = {
            author: author.value,
            content: message.value,
        };

        const request = {
            method: 'POST',
            body: JSON.stringify(user)
        };

        fetch(url, request)
            .then((response) => response.json())
            .then(() => refresh())
            .catch(() => console.log('Error'));

        author.value = '';
        message.value = '';
    }

    function refresh() {

        fetch(url)
            .then((response) => response.json())
            .then((data) => showInfo(data))
            .catch(() => console.log('Error'));

        function showInfo(data) {

            const messages = Object.keys(data);
            const toPrint = [];

            messages.forEach(id => {
                const author = data[id].author;
                const message = data[id].content;
                toPrint.push(`${author}: ${message}`);
            });

            messagesContainer.value = toPrint.join('\n');
        }
    }
}

attachEvents();