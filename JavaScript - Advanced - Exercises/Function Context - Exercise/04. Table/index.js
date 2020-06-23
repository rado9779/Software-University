function solve() {

   const tableBody = document.querySelector('tbody');
   const tableRows = tableBody.querySelectorAll('tr');

   tableBody.addEventListener('click', changeColor)

   function changeColor(e) {

      const row = e.target.parentNode;

      if (row.style.backgroundColor !== '') {
         row.style.backgroundColor = '';
      }
      else {
         for (const tr of tableRows) {
            tr.style.backgroundColor = '';
         }
         row.style.backgroundColor = '#413f5e';
      }
   }
}
