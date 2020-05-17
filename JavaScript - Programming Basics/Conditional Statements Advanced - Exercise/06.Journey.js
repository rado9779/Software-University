function holidaySchedule(money, inputSeason) {

    let budget = Number(money);
    let season = inputSeason.toLowerCase();

    let destination;
    let place;

    if (budget <= 100) {

        destination = "Bulgaria";

        if (season == "summer") {
            place = "Camp";
            budget *= 0.30;
        }
        else if (season == "winter") {
            budget *= 0.70;
            place = "Hotel";
        }
    }
    else if (budget <= 1000) {

        destination = "Balkans";

        if (season == "summer") {
            place = "Camp";
            budget *= 0.40;
        }
        else if (season == "winter") {
            budget *= 0.80;
            place = "Hotel";
        }
    }
    else if (budget > 1000) {

        destination = "Europe";
        place = "Hotel";

        if (season == "summer" || season == "winter") {
            budget *= 0.90;
        }
    }

    console.log(`Somewhere in ${destination}`);
    console.log(`${place} - ${budget.toFixed(2)}`);
}