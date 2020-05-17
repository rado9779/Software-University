function lilyToys(lilyAge, laundryPrice, toysPrice) {

    let age = Number(lilyAge);
    laundryPrice = Number(laundryPrice);
    toysPrice = Number(toysPrice);

    let birthdateMoney = 10;
    let money = 0;

    for (let i = 1; i <= age; i++) {

        if (i % 2 !== 0) {
            money += toysPrice;
        }
        else {
            money += birthdateMoney;
            money -= 1;
            birthdateMoney += 10;
        }
    }

    if (money >= laundryPrice) {
        console.log(`Yes! ${(money - laundryPrice).toFixed(2)}`);
    }
    else {
        console.log(`No! ${(laundryPrice - money).toFixed(2)}`);
    }
}


