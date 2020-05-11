function moneyForCharity(campaignDays,cookersCount,cakesCount,wafflesCount,pancakesCount){

    let days = Number(campaignDays);
    let cookers = Number(cookersCount);
    let cakes = Number(cakesCount);
    let waffles = Number(wafflesCount);
    let pancakes = Number(pancakesCount);

    let cakesSumPerDay = cakes * 45;
    let wafflesSumPerDay = waffles * 5.80;
    let pancakesSumPerDay = pancakes * 3.20;

    let totalSumForDay = (cakesSumPerDay + wafflesSumPerDay + pancakesSumPerDay) * cookers;
    let totalSum = totalSumForDay * days;
    let sumAfterCharges = totalSum - (totalSum / 8);
    
    console.log(sumAfterCharges.toFixed(2));
}