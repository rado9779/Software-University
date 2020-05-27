function sumArrNumbers(input) {

    while (input.length > 1) {

        let result = [];

        for (let i = 0; i < input.length - 1; i++) {
            result[i] = Number(input[i]) + Number(input[i + 1]);
        }

        input = result;
    }

    console.log(input.join(' '));
}
