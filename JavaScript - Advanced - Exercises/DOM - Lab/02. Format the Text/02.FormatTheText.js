function formatText() {

    const inputParagraph = document.getElementById('input');
    const outputParagraph = document.getElementById('output');

    const paragraphValue = inputParagraph.innerText;
    const outputArray = Array.from(paragraphValue.split('. '));

    let counter = 0;
    let currentParagraph = document.createElement('p');

    for (let i = 0; i < outputArray.length; i++) {

        counter++;
        currentParagraph.innerText += outputArray[i];

        if (counter === 3) {
            outputParagraph.appendChild(currentParagraph);
            currentParagraph = document.createElement('p');
            counter = 0;
        }
    }

    if (counter !== 0) {
        outputParagraph.appendChild(currentParagraph);
    }
}