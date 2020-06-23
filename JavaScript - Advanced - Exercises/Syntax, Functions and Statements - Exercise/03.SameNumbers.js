function numberDigits(input) {

    let numberToString = input.toString();
    let sum = 0;
    let areEqual = true;
    let firstDigit = numberToString[0];

    for (let i = 0; i < numberToString.length; i++) {

        sum += Number(numberToString[i]);

        if (numberToString[i] != firstDigit) {
            areEqual = false;
        }
    }

    console.log(areEqual);
    console.log(sum);
}
