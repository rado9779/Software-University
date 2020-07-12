function loadRepos() {

	const input = document.getElementById('username');
	const username = input.value;
	const repositories = document.getElementById('repos');
	const link = `https://api.github.com/users/${username}/repos`;

	fetch(link)
		.then((response) => response.json())
		.then((data) => {
			data.forEach(repository => {

				const li = document.createElement('li');
				const a = document.createElement('a');

				a.textContent = repository.full_name;
				a.href = repository.html_url;

				li.appendChild(a);
				repositories.appendChild(li);

				input.value = '';
			});
		})
		.catch(error => alert(error));
}