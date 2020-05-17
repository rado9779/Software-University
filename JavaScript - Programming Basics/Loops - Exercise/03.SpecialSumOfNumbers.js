function specialSumOfNumbers(inputStart,inputEnd,inputDivider) {
    
    let start = Number(inputStart);
    let end = Number(inputEnd);
    let divider = Number(inputDivider);

    let sum = 0;

    for (let i = start; i <= end; i++) {

        if (i % divider === 0) {
            sum += i;
        }
    }

    console.log(sum);
}