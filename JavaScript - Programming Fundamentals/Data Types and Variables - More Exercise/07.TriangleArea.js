function triangleArea(sideA, sideB, sideC) {

    let a = Number(sideA);
    let b = Number(sideB);
    let c = Number(sideC);

    let perimeter = (a + b + c) / 2;
    let area = Math.sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));

    console.log(area);
}

