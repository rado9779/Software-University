function loadCommits() {

    const username = document.getElementById('username').value;
    const repository = document.getElementById('repo').value;
    const commits = document.getElementById('commits');

    const url = `https://api.github.com/repos/${username}/${repository}/commits`;

    fetch(url)
        .then((response) => {

            if (response.status === 200) {
                return response.json();
            }
            throw response;
        })
        .then((data) => printCommits(data))
        .catch((error) => printError(error));

    function printCommits(data) {
        commits.innerHTML = '';

        data.forEach(element => {
            const li = document.createElement('li');
            li.textContent = `"${element.commit.author.name}: ${element.commit.message}" `;
            commits.appendChild(li);
        });
    }

    function printError(error) {
        commits.innerHTML = '';
        const li = document.createElement('li');
        li.textContent = `Error: ${error.status} (${error.statusText})`;
        commits.appendChild(li);
    }
}