function travelMoney(input) {

    while (true) {

        let destionation = input.shift();

        if (destionation == "End") {
            return;
        }

        let budget = Number(input.shift());
        let totalSum = 0;

        while (true) {
            let sum = Number(input.shift());
            totalSum += sum;

            if (totalSum >= budget) {
                console.log(`Going to ${destionation}!`);
                break;
            }
        }
    }
}