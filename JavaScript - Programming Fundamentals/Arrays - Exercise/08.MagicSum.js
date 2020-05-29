function uniqueNumbers(array, magicNum) {

    for (let i = 0; i < array.length - 1; i++) {

        let firstNum = array[i];

        for (let j = i + 1; j < array.length; j++) {

            let secondNum = array[j];
            let sum = firstNum + secondNum;

            if (sum === magicNum) {
                console.log(firstNum + " " + secondNum);
            }
        }
    }
}