function cooking(input) {

    let number = Number(input.shift());

    for (let i = 1; i <= 5; i++) {

        let command = input.shift();

        switch (command) {
            case "chop":
                number /= 2;
                console.log(number);
                break;
            case "dice":
                number = Math.sqrt(number);
                console.log(number);
                break;
            case "spice":
                number += 1;
                console.log(number);
                break;
            case "bake":
                number *= 3;
                console.log(number);
                break;
            case "fillet":
                number -= number * 0.20;
                console.log(number);
                break;
            default:
                break;
        }
    }
}


