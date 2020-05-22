function sumNumberDigits(num) {

    let number = Number(num);
    let sum = 0;

    while (number > 0) {

        let digit = number % 10;

        sum += digit;
        number = Math.floor(number / 10);
    }

    console.log(sum);
}

