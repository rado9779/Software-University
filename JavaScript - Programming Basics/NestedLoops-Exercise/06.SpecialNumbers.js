function specialNumbers(input) {

    let N = Number(input.shift());

    let output = "";

    for (let i = 1111; i <= 9999; i++) {

        let currentNumber = i;
        let isSpecial = true;

        while (currentNumber > 0) {
            let lastDigit = currentNumber % 10;

            if (N % lastDigit !== 0) {
                isSpecial = false;
                break;
            }

            currentNumber = Math.trunc(currentNumber / 10);
        }

        if (isSpecial) {
            output += i + " ";
        }
    }

    console.log(output);
}