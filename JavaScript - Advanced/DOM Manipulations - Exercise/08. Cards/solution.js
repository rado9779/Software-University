function solve() {

   const cards = [...document.querySelectorAll('.cards img')];

   const results = Array.from(document.querySelectorAll('#result span'));
   const history = document.querySelector('#history');

   const result = [];
   let counter = 1;

   let firstCard;
   let secondCard;
   let previouseCard;

   cards.forEach((card) => {
      card.addEventListener('click', (e) => {
         console.log(counter);
         if (counter > 1 && card.parentElement.id === previouseCard.parentElement.id) {
            return;
         }

         if (card.parentElement.id === "player1Div") {
            firstCard = card
         }
         else{
            secondCard = card;
         }

         card.src = "images/whiteCard.jpg";

         if (firstCard) {
            results[0].textContent = firstCard.name;
         }

         if (secondCard) {
            results[2].textContent = secondCard.name;
         }

         if (firstCard && secondCard) {
            
            if (Number(firstCard.name) > Number(secondCard.name)) {
               firstCard.style.border = "2px solid green";
               secondCard.style.border = "2px solid red";
            }
            else {
               firstCard.style.border = "2px solid red";
               secondCard.style.border = "2px solid green";
            }

            result.push(`[${firstCard.name} vs ${secondCard.name}] `)
         }

         if (counter % 2 === 0) {
            firstCard = undefined;
            secondCard = undefined;
         }
         
         counter++;
         previouseCard = card;
         history.textContent = result.join('');
      });
   })
}