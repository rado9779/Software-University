function saleRevenue(excursionCost,puzzlesCount,dollsCount,teddyBearsCount,minionsCount,trucksCount){
    
    excursionPrice = Number(excursionCost);

    puzzles = Number(puzzlesCount);
    dolls = Number(dollsCount);
    teddyBears = Number(teddyBearsCount);
    minions = Number(minionsCount);
    trucks = Number(trucksCount);

    let toysCount = puzzles + dolls + teddyBears + minions + trucks;

    let puzzlesSum = puzzles * 2.60;
    let dollsSum = dolls * 3;
    let teddyBearsSum = teddyBears * 4.10;
    let minionsSum = minions * 8.20;
    let trucksSum = trucks * 2;

    let totalSum = puzzlesSum + dollsSum + teddyBearsSum + minionsSum + trucksSum;

    if (toysCount >= 50) {
        totalSum -= totalSum * 0.25;
    }

    totalSum -= totalSum * 0.10;

    if (totalSum - excursionPrice >= 0) {
        console.log(`Yes! ${(totalSum - excursionPrice).toFixed(2)} lv left.`);
    }
    else{
        console.log(`Not enough money! ${(excursionPrice - totalSum).toFixed(2)} lv needed.`);
    }
}
