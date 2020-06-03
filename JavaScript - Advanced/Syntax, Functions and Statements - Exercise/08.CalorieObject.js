function caloriesCalculator(input) {

    let result = new Map();
    let product = "";
    let calories = "";

    for (let i = 0; i < input.length; i++) {

        if (i % 2 === 0) {
            product = input[i];
        }
        else {
            calories = input[i];
        }

        result.set(product, calories);
    }

    let toPrint = "";

    for (let item of result) {
        toPrint += `${item[0]}: ${item[1]}` + ", ";
    }

    console.log(`{ ${toPrint.substr(0, toPrint.length - 2)} }`);
}


