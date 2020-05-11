function holidayCost(inputDays, room, rating) {

    let days = Number(inputDays);
    let nights = Number(inputDays) - 1;
    let price = 0;
    let discount = 0;

    if (room == "room for one person") {
        price = 18 - (18 * discount);
    }
    else if (room == "apartment") {

        if (days < 10) {
            discount = 0.30;
        }
        else if (days >= 10 && days <= 15) {
            discount = 0.35;
        }
        else if (days > 15) {
            discount = 0.50;
        }
        price = 25 - (25 * discount);
    }
    else if (room == "president apartment") {

        if (days < 10) {
            discount = 0.10;
        }
        else if (days >= 10 && days <= 15) {
            discount = 0.15;
        }
        else if (days > 15) {
            discount = 0.20;
        }
        price = 35 - (35 * discount);
    }

    let totalSum = nights * price;

    if (rating == "positive") {

        totalSum *= 1.25;
    }
    else if (rating == "negative") {

        totalSum -= totalSum * 0.10;
    }

    console.log(totalSum.toFixed(2));
}
