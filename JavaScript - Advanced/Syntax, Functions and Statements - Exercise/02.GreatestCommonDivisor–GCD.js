function gcd(num1, num2) {

    let firstNumber = Math.abs(num1);
    let secondNumber = Math.abs(num2);

    if (secondNumber > firstNumber) {
        var temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }

    while (true) {

        if (secondNumber == 0) {
            console.log(firstNumber);
            return;
        }

        firstNumber %= secondNumber;

        if (firstNumber == 0) {
            console.log(secondNumber);
            return;
        }

        secondNumber %= firstNumber;
    }
}
