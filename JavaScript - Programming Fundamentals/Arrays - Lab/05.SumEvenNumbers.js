function evenNumbersSum(input) {

    let sum = 0;

    for (let i = 0; i < input.length; i++) {

        let num = Number(input[i]);

        if (num % 2 === 0) {
            sum += num;
        }
    }

    console.log(sum);
}

