function calculateExpenses(lostFightsCount, helmet, sword, shield, armor) {

    let lostFights = Number(lostFightsCount);
    let helmetPrice = Number(helmet);
    let swordPrice = Number(sword);
    let shieldPrice = Number(shield);
    let armorPrice = Number(armor);

    let brokenHelmets = 0;
    let brokenSwords = 0;
    let brokenShields = 0;
    let brokenArmors = 0;

    for (let i = 1; i <= lostFights; i++) {

        if (i % 2 === 0) {
            brokenHelmets++;
        }

        if (i % 3 === 0) {
            brokenSwords++;
        }

        if (i % 2 === 0 && i % 3 === 0) {
            brokenShields++;
            if (brokenShields % 2 === 0) {
                brokenArmors++;
            }
        }
    }

    let helmetExpenses = brokenHelmets * helmetPrice;
    let swordsExpenses = brokenSwords * swordPrice;
    let shieldExpenses = brokenShields * shieldPrice;
    let armorExpenses = brokenArmors * armorPrice;
    let totalExpenses = helmetExpenses + swordsExpenses + shieldExpenses + armorExpenses;

    console.log(`Gladiator expenses: ${totalExpenses.toFixed(2)} aureus`);
}

