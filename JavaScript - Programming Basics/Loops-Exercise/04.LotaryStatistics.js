function totoStatistics(nums) {

    let numbers = Number(nums);

    let oddSingleDigits = 0;
    let evenDigits = 0;
    let oddEndingIn7 = 0;
    let divisibleBy100 = 0;

    for (let i = 1; i <= numbers; i++) {

        if (i % 2 != 0 && i <= 9) {
            oddSingleDigits++;
        }
        if (i % 2 === 0) {
            evenDigits++;
        }
        if (i % 2 !== 0 && i % 10 === 7) {
            oddEndingIn7++;
        }
        if (100 % i === 0) {
            divisibleBy100++;
        }
    }

    let oddSingleDigitsPercents = (oddSingleDigits / numbers) * 100;
    let evenDigitsPercents = (evenDigits / numbers) * 100;
    let oddEndingIn7Percents = (oddEndingIn7 / numbers) * 100;
    let divisibleBy100Percents = (divisibleBy100 / numbers) * 100;

    console.log(oddSingleDigitsPercents.toFixed(2) + "%");
    console.log(evenDigitsPercents.toFixed(2) + "%");
    console.log(oddEndingIn7Percents.toFixed(2) + "%");
    console.log(divisibleBy100Percents.toFixed(2) + "%");
}
