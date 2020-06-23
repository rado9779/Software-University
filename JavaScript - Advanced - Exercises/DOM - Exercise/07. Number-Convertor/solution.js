function solve() {

    const input = document.getElementById('input');
    const result = document.getElementById('result');
    const button = document.querySelector('button');
    const selectMenu = document.getElementById('selectMenuTo');

    const binaryOption = document.createElement('option');
    binaryOption.textContent = 'Binary';
    binaryOption.value = 'binary';
    selectMenu.add(binaryOption);

    const hexadecimalOption = document.createElement('option');
    hexadecimalOption.textContent = 'Hexadeicmal';
    hexadecimalOption.value = 'hexadecimal';
    selectMenu.add(hexadecimalOption);

    button.addEventListener('click', onClick);

    function onClick() {

        const option = selectMenu.value;
        const inputNumber = input.value;

        if (option === 'binary') {
            result.value = Number(inputNumber).toString(2);
        }
        else if (option === 'hexadecimal') {
            result.value = Number(inputNumber).toString(16).toUpperCase();
        }
    }
}