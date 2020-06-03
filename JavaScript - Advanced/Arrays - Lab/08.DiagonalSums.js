function diagonalSums(input) {

    let primaryDiagonal = 0;
    let secondaryDiagonal = 0;

    for (let i = 0; i < input.length; i++) {

        primaryDiagonal += input[i][i];
        secondaryDiagonal += input[i][input.length - 1 - i];
    }

    console.log(primaryDiagonal + " " + secondaryDiagonal);
}

