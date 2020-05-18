function passwordValidator(input) {

    let username = input.shift();
    let correctPassword = username.split("").reverse().join("");

    let counter = 0;

    while (true) {

        let password = input.shift();

        if (password !== correctPassword) {
            counter++;

            if (counter == 4) {
                console.log(`User ${username} blocked!`);
                return;
            }

            console.log(`Incorrect password. Try again.`);
        }
        else {
            console.log(`User ${username} logged in.`);
            return;
        }
    }
}

