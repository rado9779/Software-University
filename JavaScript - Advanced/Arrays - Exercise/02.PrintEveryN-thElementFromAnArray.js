function printElementsWithSteps(array) {

    let step = Number(array.pop());

    for (let element = 0; element < array.length; element += step) {

        console.log(array[element]);
    }
}

