function sumNumbers(a, b) {

    let start = Number(a);
    let end = Number(b);

    let sum = 0;
    let result = "";

    for (let i = start; i <= end; i++) {
        sum += i;
        result += `${i} `
    }

    console.log(result);
    console.log(`Sum: ${sum}`);
}