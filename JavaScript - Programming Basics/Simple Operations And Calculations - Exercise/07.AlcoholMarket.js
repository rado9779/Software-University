function necessaryMoneyForAlcohol(priceForWhisky,beerQuantity,wineQuantity,rakijaQuantity,whiskyQuantity){

    let whiskyPrice = Number(priceForWhisky);
    let beerLiters = Number(beerQuantity);
    let wineLiters = Number(wineQuantity);
    let rakijaLiters = Number(rakijaQuantity);
    let whiskyLiters = Number(whiskyQuantity);

    let rakijaPrice = whiskyPrice / 2;
    let winePrice = rakijaPrice - (0.4 * rakijaPrice);
    let beerPrice = rakijaPrice - (0.8 * rakijaPrice);

    let rakijaSum = rakijaLiters * rakijaPrice;
    let wineSum = wineLiters * winePrice;
    let beerSum = beerLiters * beerPrice;
    let whiskySum = whiskyLiters * whiskyPrice;

    let totalSum = rakijaSum + wineSum + beerSum + whiskySum;

    console.log(totalSum.toFixed(2))
}

