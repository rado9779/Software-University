function drawOrbit(input) {

    let matrixRows = input[0];
    let matrixCols = input[1];

    let starRow = input[2];
    let starCol = input[3];

    let matrix = [];

    for (let i = 0; i < matrixRows; i++) {
        matrix[i] = [];
    }

    for (let row = 0; row < matrixRows; row++) {

        for (let col = 0; col < matrixCols; col++) {

            let matrixRow = Math.abs(row - starRow);
            let matrixCol = Math.abs(col - starCol);

            matrix[row][col] = Math.max(matrixRow, matrixCol) + 1;
        }
    }

    console.log(matrix.map(x => x.join(' ')).join('\n'));
}

