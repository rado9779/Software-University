function isValid(num){

    let number = Number(num);

    if (number < 100 || number > 200) {

        if (number != 0) {

            console.log("invalid");
        }
    }
}