function boxesMoving(input){

    let width = Number(input.shift());
    let length = Number(input.shift());
    let height = Number(input.shift());

    let volume = width * length * height;

    let hasVolume = true;

    while (true) {
        let command = input.shift();

        if (command === "Done") {
            break;
        }

        let box = Number(command);
        volume -= box;

        if (volume < 0) {
            hasVolume = false;
            break;
        }
    }

    if (hasVolume) {
        console.log(`${volume} Cubic meters left.`);
    }
    else{
        console.log(`No more free space! You need ${Math.abs(volume)} Cubic meters more.`);
    }
}