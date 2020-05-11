function landscapeYard(sqmToLandscape)
{
    let priceWithoutDiscount = sqmToLandscape * 7.61;
    let discount = priceWithoutDiscount * 0.18;
    let price = priceWithoutDiscount - discount;

    console.log(`The final price is: ${price.toFixed(2)} lv.`);
    console.log(`The discount is: ${discount.toFixed(2)} lv.`);
}
