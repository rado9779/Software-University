function aggregate(input) {

    let sum = 0;
    let inversedSum = 0;
    let concatenated = "";

    for (let i = 0; i < input.length; i++) {

        let number = Number(input[i]);

        sum += number;
        inversedSum += 1 / number;
        concatenated += number;
    }

    console.log(sum);
    console.log(inversedSum);
    console.log(concatenated);
}
