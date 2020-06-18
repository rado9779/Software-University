function solution(array, argument) {

    if (argument === 'asc') {
        array.sort((a, b) => a - b);
    }
    else if (argument === 'desc') {
        array.sort((a, b) => b - a);
    }

    return array;
}