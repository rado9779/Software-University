function lowestPrice(input) {

    let result = new Map();

    for (let i = 0; i < input.length; i++) {

        let line = input[i].split(" | ");

        let town = line[0];
        let product = line[1];
        let price = Number(line[2]);

        if (!result.has(product)) {
            result.set(product,new Map());
        }

        result.get(product).set(town,price);
    }

    for (const [product,productMap] of result) {
        
        let lowestPrice = Number.MAX_SAFE_INTEGER;
        let lowestPriceTown;

        for (const [town,price] of productMap) {
            
            if (price < lowestPrice) {
                lowestPrice = price;
                lowestPriceTown = town;
            }
        }

        console.log(`${product} -> ${lowestPrice} (${lowestPriceTown})`);
    }
}