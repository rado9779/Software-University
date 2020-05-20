function sumNumbers(num1, num2, num3) {

    let firstNumber = Number(num1);
    let secondNumber = Number(num2);
    let thirdNumber = Number(num3);

    let sum = firstNumber + secondNumber + thirdNumber;

    if (sum % 1 === 0) {
        console.log(`${sum} - Integer`);
    }
    else {
        console.log(`${sum} - Float`);
    }
}
