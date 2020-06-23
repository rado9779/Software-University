function increasingSequence(array) {

    let maxNum = 0;
    let result = [];

    for (let number = 0; number < array.length; number++) {

        let currentNum = Number(array[number]);

        if (currentNum >= maxNum) {
            result.push(currentNum);
            maxNum = currentNum;
        }
    }

    for (const num of result) {
        console.log(num);
    }
}
