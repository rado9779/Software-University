function roundNumber(first, second) {

    let number = Number(first);
    let precision = Number(second);

    if (precision > 15) {
        precision = 15;
    }

    number = number.toFixed(precision);
    console.log(parseFloat(number));
}