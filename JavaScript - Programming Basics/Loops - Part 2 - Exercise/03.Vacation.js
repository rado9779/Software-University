function travelMoney(input) {

    let neededMoney = Number(input.shift());
    let ownedMoney = Number(input.shift());

    let spendCounter = 0;
    let daysCounter = 0;

    while (true) {

        let command = input.shift();
        let money = Number(input.shift());

        daysCounter++;

        if (command == "save") {
            ownedMoney += money;
            spendCounter = 0;

            if (ownedMoney >= neededMoney) {
                console.log(`You saved the money for ${daysCounter} days.`);
                return;
            }
        }
        else if (command == "spend") {
            ownedMoney -= money;
            spendCounter++;

            if (spendCounter >= 5) {
                console.log(`You can't save the money.`);
                console.log(daysCounter);
                return;
            }

            if (ownedMoney < 0) {
                ownedMoney = 0;
            }
        }
    }
}