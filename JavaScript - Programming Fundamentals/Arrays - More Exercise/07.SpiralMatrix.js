function spiralMatrix(dimensionNum1, dimensionNum2) {

    let rows = dimensionNum1;
    let cols = dimensionNum2;
    let matrix = [];

    for (let row = 0; row < rows; row++) {
        matrix[row] = [];
    }

    let startRow = 0;
    let startCol = 0;
    let endRow = rows - 1;
    let endCol = cols - 1;
    let n = 1;

    while (startRow <= endRow || startCol <= endCol) {

        for (let col = startCol; col <= endCol; col++) {
            matrix[startRow][col] = n;
            n++;
        }

        for (let row = startRow + 1; row <= endRow; row++) {
            matrix[row][endCol] = n;
            n++;
        }

        for (let col = endCol - 1; col >= startCol; col--) {
            matrix[endRow][col] = n;
            n++;
        }

        for (let row = endRow - 1; row > startRow; row--) {
            matrix[row][startCol] = n;
            n++;
        }

        startRow++;
        startCol++;
        endRow--;
        endCol--;
    }

    console.log(matrix.map(row => row.join(' ')).join('\n'));
}