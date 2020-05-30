function magicSum(matrix) {

    let result = [];
    let isMagic = true;

    for (let row = 0; row < matrix.length; row++) {

        let rowSum = matrix[row].reduce((a, b) => a + b, 0);
        result.push(rowSum);
    }

    for (let row = 0; row < matrix.length; row++) {

        let colSum = matrix.reduce((a, b) => a + b[row], 0);
        result.push(colSum);
    }

    for (let i = 0; i < result.length - 1; i++) {

        if (result[i] != result[i + 1]) {
            isMagic = false;
        }
    }

    console.log(isMagic);
}