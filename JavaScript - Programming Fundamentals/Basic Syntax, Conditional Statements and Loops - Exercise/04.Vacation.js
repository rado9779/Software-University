function vacationPrice(peopleCount, groupType, dayOfWeek) {

    let people = Number(peopleCount);

    let price = 0;
    let discount = 0;

    if (dayOfWeek == "Friday") {

        if (groupType == "Students") {
            price = 8.45;
        }
        else if (groupType == "Business") {
            price = 10.90;
        }
        else if (groupType == "Regular") {
            price = 15;
        }
    }
    else if (dayOfWeek == "Saturday") {

        if (groupType == "Students") {
            price = 9.80;
        }
        else if (groupType == "Business") {
            price = 15.60;
        }
        else if (groupType == "Regular") {
            price = 20;
        }
    }
    else if (dayOfWeek == "Sunday") {

        if (groupType == "Students") {
            price = 10.46;
        }
        else if (groupType == "Business") {
            price = 16;
        }
        else if (groupType == "Regular") {
            price = 22.50;
        }
    }

    if (groupType == "Students" && people >= 30) {
        discount = 0.15;
    }

    if (groupType == "Business" && people >= 100) {
        people -= 10;
    }

    if (groupType == "Regular" && people >= 10 && people <= 20) {
        discount = 0.05;
    }

    let totalPrice = people * price;
    totalPrice -= totalPrice * discount;

    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

