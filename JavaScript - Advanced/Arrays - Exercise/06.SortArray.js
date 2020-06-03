function sort(array) {

    array.sort(function (a, b) {
        return a.localeCompare(b);
    });

    array.sort(function (a, b) {
        return a.length - b.length;
    });

    console.log(array.join('\n'));
}
