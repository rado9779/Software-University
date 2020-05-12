function maxNumber(input) {

    let numsCount = Number(input.shift());

    let counter = 0;
    let maxNum = Number.MIN_SAFE_INTEGER;

    while (counter != numsCount) {

        let number = Number(input.shift());

        if (number > maxNum) {
            maxNum = number;
        }
        counter++;
    }
    console.log(maxNum);
}

