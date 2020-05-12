function numbersSum(input) {

    let num = input.shift();
    let sum = 0;

    while (num !== "Stop") {
        
        let currentNum = Number(num);
        sum += currentNum;
        num = input.shift();
    }

    console.log(sum);
}