function foodCost(dogsCount,animalsCount){

    let dogsFood = dogsCount * 2.50;
    let animalFood = animalsCount * 4;
    let totalFoodCost = dogsFood + animalFood;

    console.log(totalFoodCost.toFixed(2) + " lv.");
}
