function movieMoney(movieBudget,extraCount,clothingPrice){

    let budget = Number(movieBudget);
    let extras = Number(extraCount);
    let clothPrice = Number(clothingPrice);

    let decorPrice = budget * 0.10;
    let clothingSum = extras * clothPrice;
    if (extras > 150) {
        clothingSum -= clothingSum * 0.10;
    }

    let totalExpenses = decorPrice + clothingSum;

    if (budget - totalExpenses >= 0) {
        console.log("Action!");
        console.log(`Wingard starts filming with ${(budget - totalExpenses).toFixed(2)} leva left.`);
    }
    else {
        console.log("Not enough money!");
        console.log(`Wingard needs ${(totalExpenses - budget).toFixed(2)} leva more.`);
    }
}

