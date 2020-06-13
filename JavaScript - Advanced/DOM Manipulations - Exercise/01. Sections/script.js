function create(words) {

   const container = document.getElementById('content');

   for (const element of words) {

      let div = document.createElement('div');
      let p = document.createElement('p');

      p.textContent = element;
      p.style.display = 'none';

      div.appendChild(p);
      div.addEventListener('click', function (e) {
         p.style.display = 'block';
      });

      container.appendChild(div);
   }
}