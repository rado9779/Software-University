function letterSum(product, num, money) {

    let number = Number(num);
    let budget = Number(money);

    let vowelsCount = 0;
    let consonantsCount = 0;

    for (let i = 0; i < product.length; i++) {

        let letter = product[i];

        if (letter == 'a' ||
            letter == 'e' ||
            letter == 'i' ||
            letter == 'o' ||
            letter == 'u' ||
            letter == 'y') {
            vowelsCount++;
        }
        else {
            consonantsCount++;
        }
    }

    let productValue = vowelsCount * 3 + consonantsCount;
    productValue *= number;

    if (productValue > budget) {

        console.log(`Cannot buy ${product}. Product value: ${productValue.toFixed(2)}`);
    }
    else {
        console.log(`${product} bought. Money left: ${(budget -
            productValue).toFixed(2)}`);
    }
}

