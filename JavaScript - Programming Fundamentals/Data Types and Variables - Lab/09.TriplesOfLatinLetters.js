function printLetters(input) {

    let n = Number(input);

    for (let i = 97; i < 97 + n; i++) {

        for (let j = 97; j < 97 + n; j++) {

            for (let k = 97; k < 97 + n; k++) {

                console.log(`${String.fromCharCode(i)}${String.fromCharCode(j)}${String.fromCharCode(k)}`);
            }
        }
    }
}
