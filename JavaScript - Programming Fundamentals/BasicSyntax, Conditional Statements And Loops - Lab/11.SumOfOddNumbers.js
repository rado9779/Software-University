function oddNumbers(num) {

    let n = Number(num) * 2;

    let sum = 0;

    for (let i = 1; i <= n; i++) {

        if (i % 2 !== 0) {
            sum += i;
            console.log(i);
        }
    }

    console.log(`Sum: ${sum}`);
}
