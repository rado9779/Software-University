function marketData(input) {

    let result = new Map();

    for (const line of input) {

        let tokens = line.split(" -> ");
        let town = tokens[0];
        let product = tokens[1];
        let salesAndPrice = tokens[2].split(" : ");
        let amountOfSales = Number(salesAndPrice[0]);
        let priceForOneUnit = Number(salesAndPrice[1]);
        let productPrice = amountOfSales * priceForOneUnit;

        if (!result.has(town)) {
            result.set(town, new Map());
        }

        if (!result.get(town).has(product)) {
            result.get(town).set(product, 0);
        }

        result.get(town).set(product, result.get(town).get(product) + productPrice);
    }

    for (const [town, value] of result) {
        console.log(`Town - ${town}`);

        for (const [product, price] of value) {
            console.log(`$$$${product} : ${price}`);
        }
    }
}