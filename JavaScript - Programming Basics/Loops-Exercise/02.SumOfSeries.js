function sumOfSeries(num) {
    
    let number = Number(num);
    let sum = 0;

    for (let i = 1; i <= number; i++){

        sum += i * i;
    }

    console.log(sum);
}

