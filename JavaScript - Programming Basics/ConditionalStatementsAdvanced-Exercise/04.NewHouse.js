function flowersCost(flowers, flowersCount, familyBudget) {

    count = Number(flowersCount);
    budget = Number(familyBudget);

    let sum = 0;

    if (flowers == "Roses") {
        sum = count * 5;

        if (count > 80) {
            sum -= sum * 0.10;
        }
    }
    else if (flowers == "Dahlias") {
        sum = count * 3.80;

        if (count > 90) {
            sum -= sum * 0.15;
        }
    }
    else if (flowers == "Tulips") {
        sum = count * 2.80;

        if (count > 80) {
            sum -= sum * 0.15;
        }
    }
    else if (flowers == "Narcissus") {
        sum = count * 3;

        if (count < 120) {
            sum *= 1.15;
        }
    }
    else if (flowers == "Gladiolus") {
        sum = count * 2.50;

        if (count < 80) {
            sum *= 1.20;
        }
    }

    if (budget >= sum) {
        console.log(`Hey, you have a great garden with ${count} ${flowers} and ${(budget - sum).toFixed(2)} leva left.`);
    }
    else{
        console.log(`Not enough money, you need ${(sum - budget).toFixed(2)} leva more.`);
    }
}