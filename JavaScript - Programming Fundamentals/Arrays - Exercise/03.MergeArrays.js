function mergeArrays(firstArray, secondArray) {

    let result = [];

    for (let i = 0; i < firstArray.length; i++) {

        if (i % 2 === 0) {
            let num1 = Number(firstArray[i]);
            let num2 = Number(secondArray[i]);
            result.push(num1 + num2);
        }
        else {
            result.push(firstArray[i] + secondArray[i]);
        }
    }

    console.log(result.join(" - "));
}