function largestNumber(num1, num2, num3) {

    let firstNumber = Number(num1);
    let secondNumber = Number(num2);
    let thirdNumber = Number(num3);

    let largestNumber = 0;

    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        largestNumber = firstNumber;
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        largestNumber = secondNumber;
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
        largestNumber = thirdNumber;
    }

    console.log(`The largest number is ${largestNumber}.`);
}