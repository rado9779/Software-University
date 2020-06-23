function subtract() {

    const firstNumber = document.getElementById('firstNumber');
    const secondNumber = document.getElementById('secondNumber');
    const result = document.getElementById('result');

    const firstNumberValue = Number(firstNumber.value);
    const secondNumberValue = Number(secondNumber.value);

    result.textContent = firstNumberValue - secondNumberValue;
}