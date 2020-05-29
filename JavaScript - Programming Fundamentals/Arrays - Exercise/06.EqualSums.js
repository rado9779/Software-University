function areSumsEqual(array) {

    let areEqual = false;

    for (let i = 0; i < array.length; i++) {

        let leftSum = 0;
        let rightSum = 0;

        for (let j = 0; j < i; j++) {

            leftSum += array[j];
        }

        for (let k = i + 1; k < array.length; k++) {

            rightSum += array[k];
        }

        if (leftSum === rightSum) {
            areEqual = true;
            console.log(i);
            return;
        }
    }

    if (areEqual === false) {
        console.log("no");
    }
}