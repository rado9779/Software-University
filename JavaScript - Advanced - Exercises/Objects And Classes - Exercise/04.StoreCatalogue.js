function catalogue(input) {

    let result = new Map();

    for (const line of input) {

        let tokens = line.split(" : ");
        let productName = tokens[0];
        let productFirstLetter = productName[0];
        let productPrice = Number(tokens[1]);

        if (!result.has(productFirstLetter)) {
            result.set(productFirstLetter, new Map());
        }

        if (!result.get(productFirstLetter).has(productName)) {
            result.get(productFirstLetter).set(productName, productPrice);
        }
    }

    function sortAlphabetically(a, b) {
        return a[0].localeCompare(b[0])
    }

    let sortedResult = [...result].sort(sortAlphabetically);

    for (let [letter, value] of sortedResult) {

        console.log(letter);
        let sortedProdcuts = [...value].sort(sortAlphabetically);

        for (let [product, price] of sortedProdcuts) {
            console.log(`  ${product}: ${price}`);
        }
    }
}