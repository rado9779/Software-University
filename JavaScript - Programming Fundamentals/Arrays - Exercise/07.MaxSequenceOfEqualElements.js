function longestSequence(array) {

    let count = 0;
    let maxCount = 0;
    let element;
    let result = [];

    for (let i = 0; i < array.length - 1; i++) {

        if (array[i] === array[i + 1]) {
            count++;

            if (count > maxCount) {
                maxCount = count;
                element = array[i];
            }
        }
        else {
            count = 0;
        }
    }

    for (let i = 0; i <= maxCount; i++) {
        result.push(element);
    }

    console.log(result.join(' '));
}