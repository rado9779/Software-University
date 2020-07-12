function loadRepos() {

   const div = document.getElementById('res');
   const request = new XMLHttpRequest();
   const url = 'https://api.github.com/users/testnakov/repos';

   request.addEventListener('readystatechange', function () {
      if (request.readyState === 4 && request.status === 200) {
         div.textContent = request.response;
      }
   });

   request.open('GET', url);
   request.send();
}