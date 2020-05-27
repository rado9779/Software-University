function reverse(inputArr) {

    let result = [];

    for (let i = 0; i < inputArr.length; i++) {
        result.unshift(inputArr[i]);
    }

    console.log(result.join(' '));
}
