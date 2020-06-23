function printRectangle(input) {

    let size = Number(input);

    if (size === null) {
        size = 5;
    }

    for (let row = 1; row <= size; row++) {

        let elements = "";
        for (let col = 1; col <= size; col++) {

            elements += "* ";
        }
        console.log(elements);
    }
}
