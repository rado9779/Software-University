function triangle(num) {

    let n = Number(num);

    for (let row = 1; row <= n; row++) {

        let elements = "";

        for (let col = 1; col <= row; col++) {
            elements += `${row} `
        }
        console.log(elements);
    }
}
