function solve() {

    const input = document.querySelectorAll('textarea')[0];
    const output = document.querySelectorAll('textarea')[1];
    const generateButton = document.querySelectorAll('button')[0];
    const buyButton = document.querySelectorAll('button')[1];
    const tablebody = document.querySelector('tbody');

    generateButton.addEventListener('click', generate);
    buyButton.addEventListener('click', buy);

    function generate(e) {
        const data = JSON.parse(input.value);

        for (const item of data) {
            const tableRow = document.createElement('tr');

            let image = document.createElement('td');
            image.innerHTML = `<img src ="${item.img}">`;
            tableRow.appendChild(image);

            let nametable = document.createElement('td');
            let nameParagraph = document.createElement('p');
            nameParagraph.textContent = item.name;
            nametable.appendChild(nameParagraph);
            tableRow.appendChild(nametable);

            let priceTable = document.createElement('td');
            let priceParagraph = document.createElement('p');
            priceParagraph.textContent = item.price;
            priceTable.appendChild(priceParagraph);
            tableRow.appendChild(priceTable);

            let decFactorTable = document.createElement('td');
            let decFactorParagraph = document.createElement('p');
            decFactorParagraph.textContent = item.decFactor;
            decFactorTable.appendChild(decFactorParagraph);
            tableRow.appendChild(decFactorTable);

            let checkBoxTable = document.createElement('td');
            let checkBox = document.createElement('input');
            checkBox.setAttribute('type', 'checkbox');
            checkBoxTable.appendChild(checkBox);
            tableRow.appendChild(checkBoxTable);

            tablebody.appendChild(tableRow);
        }
    }

    function buy(e) {

        let furnitures = [];
        let totalPrice = 0;
        let decoration = 0;
        let count = 0;

        let tableRows = Array.from(document.getElementsByTagName('tr'));

        for (let i = 2; i < tableRows.length; i++) {

            if (tableRows[i].children[4].children[0].checked) {

                furnitures.push(tableRows[i].children[1].textContent);
                totalPrice += Number(tableRows[i].children[2].textContent);
                decoration += Number(tableRows[i].children[3].textContent);

                count++;
            }
        }

        output.value += `Bought furniture: ${furnitures.join(', ')}\n`;
        output.value += `Total price: ${totalPrice.toFixed(2)}\n`;
        output.value += `Average decoration factor: ${decoration / count}`;
    }
}