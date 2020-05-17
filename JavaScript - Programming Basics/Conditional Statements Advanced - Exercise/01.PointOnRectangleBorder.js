function pointOnRectangleBorder(inputX1, inputY1, inputX2, inputY2, inputX, inputY) {

    let x = Number(inputX);
    let x1 = Number(inputX1);
    let x2 = Number(inputX2)

    let y = Number(inputY);
    let y1 = Number(inputY1);
    let y2 = Number(inputY2);

    let firstCondition = (x == x1 || x == x2) && (y >= y1 && y <= y2);
    let secondCondition = (y == y1 || y == y2) && (x >= x1 && x <= x2);

    if (firstCondition || secondCondition) {

        console.log("Border");
    }
    else {
        console.log("Inside / Outside");
    }
}