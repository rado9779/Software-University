function factory(input) {

    let result = {};
    let parsedInput = JSON.parse(input);

    for (const objectInput of parsedInput) {

        for (const objectKey of Object.keys(objectInput)) {

            if (Object.keys(result).includes(objectKey) === false) {

                result[objectKey] = objectInput[objectKey];
            }
        }
    }

    return result;
}