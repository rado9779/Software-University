function biggestNumber(input) {

    let maxNumber = Number.MIN_SAFE_INTEGER;

    for (var row = 0; row < input.length; row++) {

        for (var col = 0; col < input[row].length; col++) {

            let number = input[row][col];

            if (number > maxNumber) {
                maxNumber = number;
            }
        }
    }

    console.log(maxNumber);
}


