function fruitMoney(fruit, weightInGrams, pricePerKg) {

    let weight = Number(weightInGrams) / 1000;
    let price = Number(pricePerKg) * weight;

    console.log(`I need $${price.toFixed(2)} to buy ${weight.toFixed(2)} kilograms ${fruit}.`);
}
