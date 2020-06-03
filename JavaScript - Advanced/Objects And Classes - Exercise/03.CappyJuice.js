function juiceBottles(input) {

    let juiceBottles = {};
    let juiceQuantity = {};

    for (const line of input) {

        let tokens = line.split(" => ");
        let juice = tokens[0];
        let quantity = Number(tokens[1]);

        if (juiceQuantity[juice] === undefined) {
            juiceQuantity[juice] = quantity;
        }
        else {
            juiceQuantity[juice] += quantity;
        }

        if (juiceQuantity[juice] >= 1000) {
            let bottles = Math.floor(juiceQuantity[juice] / 1000);
            juiceBottles[juice] = bottles;
        }
    }

    for (const key of Object.keys(juiceBottles)) {
        console.log(`${key} => ${juiceBottles[key]}`);
    }
}