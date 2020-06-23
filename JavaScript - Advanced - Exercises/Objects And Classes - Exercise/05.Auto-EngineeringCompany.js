function carsInfo(input) {

    let result = new Map();

    for (const line of input) {

        let tokens = line.split(" | ");

        let carBrand = tokens[0];
        let carModel = tokens[1];
        let carCount = Number(tokens[2]);

        if (!result.has(carBrand)) {
            result.set(carBrand, new Map());
        }

        if (!result.get(carBrand).get(carModel)) {
            result.get(carBrand).set(carModel, 0);
        }

        result.get(carBrand).set(carModel, result.get(carBrand).get(carModel) + carCount);
    }

    for (let [brand, value] of result) {
        console.log(brand);

        for (let [model, count] of value) {
            console.log(`###${model} -> ${count}`);
        }
    }
}