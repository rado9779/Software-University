function hotelRoom(month, days) {

    let nights = Number(days);
    let studio = 0;
    let apartment = 0;

    if (month == "May" || month == "October") {
        studio = 50;
        apartment = 65;

        if (nights > 7 && nights <= 14) {
            studio -= studio * 0.05;
        }
        else if(nights > 14){
            studio -= studio * 0.30;
            apartment -= apartment * 0.10;
        }
    }
    else if (month == "June" || month == "September") {
        studio = 75.20;
        apartment = 68.70;

        if(nights > 14){
            studio -= studio * 0.20;
            apartment -= apartment * 0.10;
        }
    }
    else if (month == "July" || month == "August") {
        studio = 76;
        apartment = 77;

        if(nights > 14){
            apartment -= apartment * 0.10;
        }
    }

    console.log(`Apartment: ${(apartment * nights).toFixed(2)} lv.`);
    console.log(`Studio: ${(studio * nights).toFixed(2)} lv.`);
}
