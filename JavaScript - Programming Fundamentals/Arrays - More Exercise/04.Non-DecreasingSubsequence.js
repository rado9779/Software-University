function decreasingSequence(input) {

    let maxNum = input[0];

    let result = input.filter(x => {

        if (x >= maxNum) {
            maxNum = x;
        }
        return x >= maxNum;
    });

    console.log(result.join(' '));
}