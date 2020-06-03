function radar(input) {

    let speed = Number(input.shift());
    let area = input.shift();

    let overTheLimit = 0;

    if (area === "motorway") {

        if (speed > 130) {
            overTheLimit = speed - 130;
        }
    }
    else if (area === "interstate") {

        if (speed > 90) {
            overTheLimit = speed - 90;
        }
    }
    else if (area === "city") {

        if (speed > 50) {
            overTheLimit = speed - 50;
        }
    }
    else if (area === "residential") {

        if (speed > 20) {
            overTheLimit = speed - 20;
        }
    }

    if (overTheLimit > 0 && overTheLimit <= 20) {
        console.log("speeding");
    }
    else if (overTheLimit > 20 && overTheLimit <= 40) {
        console.log("excessive speeding ");
    }
    else if (overTheLimit > 40) {
        console.log("reckless driving");
    }
}

