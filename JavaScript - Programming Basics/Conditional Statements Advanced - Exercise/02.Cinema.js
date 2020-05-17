function cinema(type,inputRows,inputColumns){

    rows = Number(inputRows);
    cols = Number(inputColumns);

    let income = 0;

    if (type == "Premiere") {
        income = rows * cols * 12.0;
    }
    else if (type == "Normal"){
        income = rows * cols * 7.50;
    }
    else if(type == "Discount"){
        income = rows * cols * 5.00;
    }
    console.log(income.toFixed(2) + " lv");
}