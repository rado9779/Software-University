function cakePieces(input) {

    let cakeWidth = Number(input.shift());
    let cakeLength = Number(input.shift());

    let cakeSize = cakeWidth * cakeLength;
    let taken = 0;

    while (cakeSize >= taken) {

        let command = input.shift();

        if (command == "STOP") {
            break;
        }

        let pieces = Number(command);
        taken += pieces;
    }

    if (taken > cakeSize) {
        console.log(`No more cake left! You need ${taken - cakeSize} pieces more.`);
        return;
    }
    else {
        console.log(`${cakeSize - taken} pieces are left.`);
    }
}