function wordsCount(input) {

    let result = {};

    let array = input[0].split(/\W+/).filter(x => x != "");

    for (const element of array) {

        if (result[element] === undefined) {
            result[element] = 0;
        }
        result[element]++;
    }

    let convertedToJSON = JSON.stringify(result);
    console.log(convertedToJSON);
}