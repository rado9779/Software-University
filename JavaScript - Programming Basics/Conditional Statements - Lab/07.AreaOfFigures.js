function figureArea(figure,parameterA,parameterB){

    let a = Number(parameterA);
    let b = Number(parameterB);
    let result = 0;

    if (figure == "square") {
        result =  a * a;
    }
    else if (figure == "rectangle"){
        result = a * b;
    }
    else if(figure == "circle"){
        result = Math.PI * a * a;
    }
    else if(figure == "triangle"){
        result = (a * b) / 2;
    }

    console.log(result.toFixed(3));
}

