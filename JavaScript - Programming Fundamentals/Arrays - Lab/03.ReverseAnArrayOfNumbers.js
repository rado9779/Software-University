function reverse(N, inputArray) {

    let n = Number(N);
    let arr = [];

    for (let i = 0; i < n; i++) {
        arr.unshift(inputArray[i]);
    }

    console.log(arr.join(' '));
}
