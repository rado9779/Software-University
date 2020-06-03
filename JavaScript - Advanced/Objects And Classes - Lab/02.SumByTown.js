function townsIncome(input) {

    let result = {};

    for (let i = 0; i < input.length; i += 2) {

        let town = input[i];
        let income = Number(input[i + 1]);

        if (result[town] === undefined) {
            result[town] = income;
        }
        else {
            result[town] += income;
        }
    }

    let converted = JSON.stringify(result);
    console.log(converted);
}
