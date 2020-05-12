function minNumber(input) {

    let numsCount = Number(input.shift());

    let counter = 0;
    let minNum = Number.MAX_SAFE_INTEGER;

    while (counter != numsCount) {

        let number = Number(input.shift());

        if (number < minNum) {
            minNum = number;
        }
        counter++;
    }
    console.log(minNum);
}

