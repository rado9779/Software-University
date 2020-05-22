function yieldSpice(input) {

    let yield = Number(input);
    let days = 0;
    let totalAmount = 0;

    while (yield >= 100) {
        totalAmount += yield;
        totalAmount -= 26;
        yield -= 10;
        days++;
    }

    if (days > 0) {
        totalAmount -= 26;
    }

    console.log(days);
    console.log(totalAmount);
}
