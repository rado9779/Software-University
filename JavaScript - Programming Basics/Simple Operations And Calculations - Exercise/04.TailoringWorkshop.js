function orderPrice(tablesCount,tablesLength,tablesWidth){

    let count = Number(tablesCount);
    let length = Number(tablesLength);
    let width = Number(tablesWidth);

    let tableclothsArea = count * (length + 2 * 0.30) * (width + 2 * 0.30);
    let squareArea = count * (length / 2) * (length / 2);

    let priceInUSD = Number(tableclothsArea * 7 + squareArea * 9);
    let priceInLv = Number(priceInUSD * 1.85);

    console.log(priceInUSD.toFixed(2) + " USD");
    console.log(priceInLv.toFixed(2) + " BGN");
}
