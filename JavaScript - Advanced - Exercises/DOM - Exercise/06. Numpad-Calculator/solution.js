function solve() {

    const expression = document.getElementById('expressionOutput');
    const result = document.getElementById('resultOutput');
    const calculator = document.getElementById("calculator");

    let operator = false;
    let text = '';
    const operators = ['/', '*', '-', '+'];
    const numbers = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    const regex = /^\d+(\.\d+)? [*/+-] \d+(\.\d+)?$/g;

    calculator
        .addEventListener('click', (x) => {

            let button = x.target.value;

            if (button === 'Clear') {
                expression.innerHTML = '';
                result.innerHTML = '';
                text = '';
                operator = false;
            }
            if (result.innerHTML != '') {
                return '';
            }
            if (numbers.includes(button) || (button === '.' && text != '')) {
                text += button;
                expression.innerHTML = text;
            }
            else if (operators.includes(button) && !operator && !text.endsWith('.')) {
                text += ` ${button} `;
                expression.innerHTML = text;
                operator = true;
            }
            else if (button === '=') {

                if (regex.test(text)) {
                    printResult();
                }
                else {
                    result.innerHTML = NaN;
                }
            }
        });

    function printResult() {

        let tokens = text.split(' ');
        let a = Number(tokens[0]);
        let sign = tokens[1];
        let b = Number(tokens[2]);

        if (sign === '+') {
            result.innerHTML = a + b;
        }
        else if (sign === '-') {
            result.innerHTML = a - b;
        }
        else if (sign === '/') {
            result.innerHTML = a / b;
        }
        else if (sign === '*') {
            result.innerHTML = a * b;
        }
    }
}