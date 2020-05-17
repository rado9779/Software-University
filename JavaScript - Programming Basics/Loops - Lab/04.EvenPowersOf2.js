function evenPowers(num) {

    let n = Number(num);
    let number = 1;

    for (let index = 0; index <= n; index += 2) {

        console.log(number);
        number = number * 2 * 2;
    }
}

