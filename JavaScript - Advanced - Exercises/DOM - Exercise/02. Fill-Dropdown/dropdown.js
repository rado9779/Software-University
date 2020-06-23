function addItem() {

    const textInput = document.querySelector('#newItemText');
    const valueInput = document.querySelector('#newItemValue');
    const menu = document.querySelector('#menu');

    const text = textInput.value;
    const value = valueInput.value;

    const option = document.createElement('option');
    option.textContent = text;
    option.value = value;
    menu.appendChild(option);

    textInput.value = '';
    valueInput.value = '';
}