function negativeAndPositiveNumbers(input) {

    let result = [];

    for (let i = 0; i < input.length; i++) {

        let number = input[i];

        if (number < 0) {
            result.unshift(number);
        }
        else {
            result.push(number);
        }
    }

    for (let element of result) {
        console.log(element);;
    }
}
