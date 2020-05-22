function isPrime(num) {

    let number = Number(num);
    let isPrime = true;

    for (var i = 2; i < number; i++) {

        if (num % i === 0) {
            isPrime = false;
        }
    }

    console.log(isPrime);
}
