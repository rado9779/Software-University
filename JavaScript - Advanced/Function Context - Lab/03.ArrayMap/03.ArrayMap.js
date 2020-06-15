function arrayMap(array, inputFunction) {

    return array.reduce(function (acc, curr) {
        return acc.concat(inputFunction(curr));
    }, [])
}