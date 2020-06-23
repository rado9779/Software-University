function doubledOddNumbers(input) {

    let result = [];

    for (let i = 0; i < input.length; i++) {

        if (i % 2 !== 0) {

            let number = Number(input[i]);
            result.unshift(number * 2);
        }
    }

    console.log(result.join(" "));
}
