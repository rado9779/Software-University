function equalElements(input) {

    let equalNeighbors = 0;

    for (var row = 0; row < input.length; row++) {

        for (var col = 0; col < input[row].length - 1; col++) {

            if (input[row][col] == input[row][col + 1]) {
                equalNeighbors++;
            }
        }
    }

    for (var row = 0; row < input.length - 1; row++) {

        for (var col = 0; col < input[row].length; col++) {

            if (input[row][col] == input[row + 1][col]) {
                equalNeighbors++;
            }
        }
    }

    console.log(equalNeighbors);
}

