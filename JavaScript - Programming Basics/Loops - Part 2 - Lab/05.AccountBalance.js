function accountBalance(input) {

    let contributionsCount = Number(input.shift());

    let counter = 0;
    let balance = 0.0;

    while (counter != contributionsCount) {

        let contribution = Number(input.shift());

        if (contribution < 0) {
            console.log("Invalid operation!");
            break;
        }
        else {
            balance += contribution;
            console.log(`Increase: ${contribution.toFixed(2)}`);
        }
        counter++;
    }

    console.log(`Total: ${balance.toFixed(2)}`);
}

