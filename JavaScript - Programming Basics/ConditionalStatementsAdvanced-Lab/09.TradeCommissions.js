function calculateCommission(town, inputSales) {

    let sales = Number(inputSales);
    let commission = 0;

    if (sales >= 0 && sales <= 500) {

        if (town == "Sofia") {
            commission = 0.05;
        }
        else if (town == "Varna") {
            commission = 0.045;
        }
        else if (town == "Plovdiv") {
            commission = 0.055;
        }
        else {
            console.log("error")
        }
    }
    else if (sales > 500 && sales <= 1000) {

        if (town == "Sofia") {
            commission = 0.07;
        }
        else if (town == "Varna") {
            commission = 0.075;
        }
        else if (town == "Plovdiv") {
            commission = 0.08;
        }
        else {
            console.log("error")
        }
    }
    else if (sales > 1000 && sales <= 10000) {

        if (town == "Sofia") {
            commission = 0.08;
        }
        else if (town == "Varna") {
            commission = 0.10;
        }
        else if (town == "Plovdiv") {
            commission = 0.12;
        }
        else {
            console.log("error")
        }

    }
    else if (sales > 10000) {

        if (town == "Sofia") {
            commission = 0.12;
        }
        else if (town == "Varna") {
            commission = 0.13;
        }
        else if (town == "Plovdiv") {
            commission = 0.145;
        }
        else {
            console.log("error")
        }
    }
    else {
        console.log("error")
    }

    if (commission != 0) {

        console.log((sales * commission).toFixed(2));
    }
}

