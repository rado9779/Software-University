function printElementsWithSteps(array) {

    let step = Number(array.pop());
    let result = [];

    for (let element = 0; element < array.length; element += step) {

        result.push(array[element]);
    }

    console.log(result.join(' '));
}