function solve() {

    const inputs = document.querySelectorAll('input');
    const checkButton = document.querySelectorAll('button')[0];
    const clearButton = document.querySelectorAll('button')[1];

    const table = document.querySelector('table');
    const checkParagraph = document.querySelectorAll('#check p')[0];

    checkButton.style.cursor = 'pointer';
    clearButton.style.cursor = 'pointer';

    clearButton.addEventListener('click', reset);
    checkButton.addEventListener('click', checkResult);

    function reset() {
        [...inputs].forEach(input => (input.value = ''));
        table.style.border = 'none';
        checkParagraph.textContent = '';
    }

    function checkResult() {

        let matrix = [
            [inputs[0].value, inputs[1].value, inputs[2].value],
            [inputs[3].value, inputs[4].value, inputs[5].value],
            [inputs[6].value, inputs[7].value, inputs[8].value]
        ];

        let isSolved = true;

        for (let i = 1; i < matrix.length; i++) {
            let row = matrix[i];
            let col = matrix.map(row => row[i]);

            if (col.length != [...new Set(col)].length || row.length != [...new Set(row)].length) {
                isSolved = false;
                break;
            }
        }

        if (isSolved) {
            table.style.border = '2px solid green';
            checkParagraph.style.color = 'green';
            checkParagraph.textContent = 'You solve it! Congratulations!';
        } 
        else {
            table.style.border = '2px solid red';
            checkParagraph.style.color = 'red';
            checkParagraph.textContent = 'NOP! You are not done yet...';
        }
    }
}