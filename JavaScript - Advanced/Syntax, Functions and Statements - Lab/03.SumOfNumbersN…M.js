function numbersSum(m, n) {

    let start = Number(m);
    let end = Number(n);

    let sum = 0;

    for (let number = start; number <= end; number++) {
        sum += number;
    }

    console.log(sum);
}