function rotateArray(array, count) {

    for (let i = 0; i < count; i++) {
        array.push(array.shift());
    }

    console.log(array.join(' '));
}
