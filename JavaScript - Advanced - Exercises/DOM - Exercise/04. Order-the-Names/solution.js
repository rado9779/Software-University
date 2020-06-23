function solve() {

    const button = document.querySelector('button');
    const inputText = document.querySelector('input');
    const orderedList = document.querySelector('ol');
    const listItem = orderedList.getElementsByTagName("li");

    button.addEventListener('click', onClick);

    function onClick() {

        let inputName = inputText.value;

        if (inputName) {

            let currentName = "";
            currentName += inputName[0].toUpperCase();

            for (let i = 1; i < inputName.length; i++) {
                currentName += inputName[i].toLowerCase();
            }

            let index = currentName.charCodeAt(0) - 65;

            if (listItem[index].textContent.length === 0) {
                listItem[index].textContent += currentName;
            }
            else {
                listItem[index].textContent += ", " + currentName;
            }

            inputText.value = null;
        }
    }
}