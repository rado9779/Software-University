function convertMetrics(num,from,to){

    let number = Number(num);

    if (from == "mm" && to == "cm") {
        number /= 10;
    }
    if (from == "mm" && to == "m") {
        number /= 1000;
    }
    if (from == "cm" && to == "mm" ) {
        number *= 10;
    }
    if (from == "cm" && to == "m" ) {
        number /= 100;
    }
    if (from == "m" && to == "mm" ) {
        number *= 1000;
    }
    if (from == "m" && to == "cm" ) {
        number *= 100;
    }

    console.log(number.toFixed(3));
}
