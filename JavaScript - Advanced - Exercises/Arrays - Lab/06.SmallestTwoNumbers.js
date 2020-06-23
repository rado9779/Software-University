function smallestNumbers(input) {

    function compareNumbers(a, b) {
        return a - b;
    }

    input.sort(compareNumbers);
    let result = input.slice(0, 2);
    console.log(result.join(" "));
}

