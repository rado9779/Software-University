function passwordGenerator(input) {

    let n = Number(input.shift());
    let L = Number(input.shift());

    let output = '';

    for (let i = 1; i <= n; i++) {

        for (let j = 1; j <= n; j++) {

            for (let k = 97; k < 97 + L; k++) {

                for (let l = 97; l < 97 + L; l++) {

                    for (let m = 1; m <= n; m++) {

                        if (m > i && m > j) {
                            let thirdChar = String.fromCharCode(k);
                            let fourthChar = String.fromCharCode(l);

                            output += `${i}${j}${thirdChar}${fourthChar}${m} `;
                        }
                    }
                }
            }
        }
    }

    console.log(output);
}
