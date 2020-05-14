function calculationScore(input) {

    let juryCount = Number(input.shift());

    let ratings = 0;
    let counter = 0;

    while (true) {

        let presentationName = input.shift();

        if (presentationName == "Finish") {
            break;
        }

        let presentationRatings = 0;

        for (let i = 1; i <= juryCount; i++) {

            let rate = Number(input.shift());
            presentationRatings += rate;
        }

        let presentationAvgRate = (presentationRatings / juryCount);

        counter++;
        ratings += presentationAvgRate;

        console.log(`${presentationName} - ${presentationAvgRate.toFixed(2)}.`);
    }

    console.log(`Student's final assessment is ${(ratings / counter).toFixed(2)}.`);
}
