function sortNumbers(num1, num2, num3) {

    let firstNumber = Number(num1);
    let secondNumber = Number(num2);
    let thirdNumber = Number(num3);

    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        console.log(firstNumber);

        if (secondNumber > thirdNumber) {
            console.log(secondNumber);
            console.log(thirdNumber);
        }
        else {
            console.log(thirdNumber);
            console.log(secondNumber);
        }
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) {

        console.log(secondNumber);

        if (firstNumber > thirdNumber) {
            console.log(firstNumber);
            console.log(thirdNumber);
        }
        else {
            console.log(thirdNumber);
            console.log(firstNumber);
        }
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber) {

        console.log(thirdNumber);

        if (firstNumber > secondNumber) {
            console.log(firstNumber);
            console.log(secondNumber);
        }
        else {
            console.log(secondNumber);
            console.log(firstNumber);
        }
    }
}