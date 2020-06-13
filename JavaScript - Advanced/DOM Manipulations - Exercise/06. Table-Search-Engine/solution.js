function solve() {

   const input = document.getElementById('searchField');
   const searchButton = document.getElementById('searchBtn');
   const tableBody = document.querySelectorAll('td');

   searchButton.addEventListener('click', onclick);

   function onclick(e) {

      for (const td of tableBody) {
         td.parentNode.classList.remove('select');
      }

      if (input.value.length > 0) {

         for (const td of tableBody) {

            if (td.textContent.includes(input.value)) {
               td.parentNode.classList.add('select');
            }
         }

         input.value = '';
      }
   }
}