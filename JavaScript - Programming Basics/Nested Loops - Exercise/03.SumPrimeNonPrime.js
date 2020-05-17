function primeNonprime(input) {

    let command = input.shift();

    let primeSum = 0;
    let nonPrimeSum = 0;

    while (true) {

        if (command == "stop") {
            break;
        }

        let number = Number(command);

        if (number < 0) {
            console.log("Number is negative.");
            command = input.shift();
            continue;
        }

        let isPrime = true;

        if (number == 1) {
            isPrime = false;
        }
        else {
            for (let i = number; i >= 2; i--) {

                if (number % i == 0 && i != number) {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime) {
            primeSum += number;
        }
        else {
            nonPrimeSum += number;
        }

        command = input.shift();
    }

    console.log(`Sum of all prime numbers is: ${primeSum}`);
    console.log(`Sum of all non prime numbers is: ${nonPrimeSum}`);
}