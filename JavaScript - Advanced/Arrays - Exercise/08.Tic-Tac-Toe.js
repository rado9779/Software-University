function seaChess(input) {

    let ground = [
        [false, false, false],
        [false, false, false],
        [false, false, false]
    ];

    let player = 'X';

    for (let line of input) {

        let splitted = line.split(' ').map(Number);
        let currentRow = splitted[0];
        let currCol = splitted[1];

        if (ground[currentRow][currCol] !== false) {
            console.log('This place is already taken. Please choose another!');
            continue;
        }
        else {
            ground[currentRow][currCol] = player;
        }

        for (let i = 0; i < 3; i++) {

            if (
                ground[i][0] === player &&
                ground[i][1] === player &&
                ground[i][2] === player
            ) {
                console.log(`Player ${player} wins!`);
                printMatrix();
                return;
            }
            else if (
                ground[0][i] === player &&
                ground[1][i] === player &&
                ground[2][i] === player
            ) {
                console.log(`Player ${player} wins!`);
                printMatrix();
                return;
            }
        }

        if (
            ground[0][0] === player &&
            ground[1][1] === player &&
            ground[2][2] === player
        ) {
            console.log(`Player ${player} wins!`);
            printMatrix();
            return;
        }
        else if (
            ground[0][2] === player &&
            ground[1][1] === player &&
            ground[2][0] === player
        ) {
            console.log(`Player ${player} wins!`);
            printMatrix();
            return;
        }

        let freeSpace = false;

        for (let row = 0; row < ground.length; row++) {
            if (ground[row].includes(false)) {
                freeSpace = true;
            }
        }

        if (freeSpace === false) {
            console.log('The game ended! Nobody wins :(');
            printMatrix();
            return;
        }

        if (player === 'X') {
            player = 'O';
        }
        else {
            player = 'X';
        }
    }

    function printMatrix() {
        for (let row = 0; row < ground.length; row++) {
            console.log(ground[row].join('\t'));
        }
    }
}


