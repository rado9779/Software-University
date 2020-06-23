function diagonals(input) {

    let matrix = input.map(x => x.split(' ').map(Number));
    let primaryDiagonal = 0;
    let secondaryDiagonal = 0;

    for (let i = 0; i < matrix.length; i++) {

        primaryDiagonal += matrix[i][i];
        secondaryDiagonal += matrix[i][matrix.length - 1 - i];
    }

    if (primaryDiagonal === secondaryDiagonal) {

        for (let row = 0; row < matrix.length; row++) {

            for (let col = 0; col < matrix.length; col++) {

                if (row === col || row + col + 1 === matrix.length) {
                    continue;
                }
                matrix[row][col] = primaryDiagonal;
            }
        }
    }

    console.log(matrix.map(x => x.join(' ')).join('\n'));
}
