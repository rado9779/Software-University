function solve() {

   let totalPrice = 0;
   let cart = [];
   let isReady = false;
   const output = document.querySelector("body > div > textarea");

   Object.values(document.getElementsByTagName('button')).map(e => e.addEventListener('click', function (x) {

      let button = x.target.className;

      if (button === 'add-product' && isReady === false) {

         let products = {
            'Bread': 0.80,
            'Milk': 1.09,
            'Tomatoes': 0.99
         };

         let item = x.target.parentNode.parentNode.children[1].children[0].textContent;
         let outputLine = `Added ${item} for ${products[item].toFixed(2)} to the cart.`;
         totalPrice += products[item];

         if (!cart.includes(item)) {
            cart.push(item);
         }
         output.textContent += `${outputLine}\n`;
      }
      else if (button === 'checkout' && isReady === false) {

         let info = `You bought ${cart.join(', ')} for ${totalPrice.toFixed(2)}.`;
         isReady = true;
         output.textContent += `${info}\n`;
      }
   }));
}