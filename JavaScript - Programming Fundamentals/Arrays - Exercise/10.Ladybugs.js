function ladybugFly(input) {

    let field = [];
    let fieldSize = input.shift();
    let ladybugIndices = input.shift().split(' ').map(Number);

    for (let i = 0; i < fieldSize; i++) {
        field[i] = 0;
    }

    for (let i = 0; i < fieldSize; i++) {

        let index = ladybugIndices[i];

        if (index >= 0 && index < fieldSize) {
            field[index] = 1;
        }
    }

    for (let i = 0; i < input.length; i++) {

        let commandLine = input[i].split(' ');
        let position = Number(commandLine[0]);
        let direction = commandLine[1];
        let times = Number(commandLine[2]);
        let nextPosition = 0;

        if (field[position] === 0 || position < 0 || position > field.length - 1) {
            continue;
        }

        field[position] = 0;

        if (times < 0) {

            if (direction  === "right" ) {
                direction = "left";
            }
            else{
                direction = "right";
            }

            times = Math.abs(times);
        }

        if (direction === "right") {
            nextPosition = position + times;
        } 
        else if (direction === "left") {
            nextPosition = position - times;
        }

        while (field[nextPosition] === 1) {

            if (direction === "right") {
                nextPosition += times;
            } 
            else if (direction === "left") {
                nextPosition -= times;
            }
        }

        if (nextPosition > field.length - 1 || nextPosition < 0) {
            continue;
        }

        field[nextPosition] = 1;
    }

    console.log(field.join(' '));
}