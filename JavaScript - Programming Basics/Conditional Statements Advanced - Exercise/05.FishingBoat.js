function tripCost(groupBudget, season, fishermenCount) {

    let budget = Number(groupBudget);
    let fishermen = Number(fishermenCount);

    let boatRent = 0;

    if (season == "Spring") {
        boatRent = 3000;
    }
    else if (season == "Summer" || season == "Autumn") {
        boatRent = 4200;
    }
    else if (season == "Winter") {
        boatRent = 2600;
    }

    if (fishermen <= 6) {
        boatRent -= boatRent * 0.10;
    }
    else if (fishermen >= 7 && fishermen <= 11) {
        boatRent -= boatRent * 0.15;
    }
    else if (fishermen >= 12) {
        boatRent -= boatRent * 0.25;
    }

    if (fishermen % 2 == 0 && season !== "Autumn") {
        boatRent -= boatRent * 0.05;
    }


    if (budget >= boatRent) {
        console.log(`Yes! You have ${(budget - boatRent).toFixed(2)} leva left.`);
    }
    else {
        console.log(`Not enough money! You need ${(boatRent - budget).toFixed(2)} leva.`);
    }

}

