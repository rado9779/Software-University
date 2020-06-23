function uniqueSequences(input) {

    let result = [];

    for (let line of input) {
        let arr = JSON.parse(line).sort((a, b) => b - a);
        result.push(arr);
    }

    result = new Set(result
        .sort((a, b) => a.length - b.length)
        .map((arr) => arr.join(', ')));

    for (let arr of result) {
        console.log(`[${arr}]`);
    }
}