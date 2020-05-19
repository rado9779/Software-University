function distance(xOne, yOne, xTwo, yTwo) {

    let x1 = Number(xOne);
    let y1 = Number(yOne);
    let x2 = Number(xTwo);
    let y2 = Number(yTwo);

    let X = x1 - x2;
    let Y = y1 - y2;

    let result = Math.sqrt(X * X + Y * Y);

    console.log(result);
}