function moneyForFuel(km, people, price) {

    let distance = Number(km);
    let passengers = Number(people);
    let fuelPrice = Number(price);

    let neededFuel = (distance / 100) * 7;
    neededFuel += passengers * 0.1;
    let totalPrice = neededFuel * fuelPrice;

    console.log(`Needed money for that trip is ${totalPrice}lv.`);
}