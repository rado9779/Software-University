function modifyArray(array) {

    let inputArraySum = array.reduce((a, b) => a + b);

    for (let i = 0; i < array.length; i++) {

        if (array[i] % 2 === 0) {
            array[i] += i;
        }
        else {
            array[i] -= i;
        }
    }

    let modifiedArraySum = array.reduce((a, b) => a + b);

    console.log(array);
    console.log(inputArraySum);
    console.log(modifiedArraySum);
}