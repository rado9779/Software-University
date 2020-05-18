function bitcoinPurchase(input) {

    let bitcoins = 0;
    let bitcoinDay = 0;
    let days = 0;
    let money = 0;
    let totalMoney = 0;

    for (let i = 0; i < input.length; i++) {

        days++;

        if (days % 3 === 0) {
            input[i] = input[i] - (input[i] * 0.3);
        }

        money = input[i] * 67.51;
        totalMoney += money;

        while (totalMoney >= 11949.16) {

            totalMoney -= 11949.16;
            bitcoins++;

            if (bitcoins === 1) {
                bitcoinDay = days;
            }
        }
    }

    console.log(`Bought bitcoins: ${bitcoins}`);

    if (bitcoinDay > 0) {
        console.log(`Day of the first purchased bitcoin: ${bitcoinDay}`);
    }

    console.log(`Left money: ${totalMoney.toFixed(2)} lv.`);
}