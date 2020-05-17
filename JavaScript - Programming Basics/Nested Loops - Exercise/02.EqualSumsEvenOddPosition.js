function equalSum(input) {

    let firstNum = Number(input.shift());
    let secondNum = Number(input.shift());

    let printLine = '';

    for (let i = firstNum; i <= secondNum; i++) {

        let oddSum = 0;
        let evenSum = 0;
        let currentNum = '' + i;

        for (let j = 0; j < currentNum.length; j++) {

            let currentDigit = Number(currentNum[j]);

            if (j % 2 === 0) {
                evenSum += currentDigit;
            }
            else {
                oddSum += currentDigit;
            }

        }

        if (oddSum === evenSum) {
            printLine += i + ' ';
        }
    }
    console.log(printLine);
}
