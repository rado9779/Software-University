function solve() {

    let firstElement;
    let secondElement;
    let resultElement;

    return {

        init: function (selector1, selector2, resultSelector) {
            firstElement = $(selector1);
            secondElement = $(selector2);
            resultElement = $(resultSelector);
        },
        add: function () {
            resultElement.val(Number(firstElement.val()) + Number(secondElement.val()));
        },
        subtract: function () {
            resultElement.val(Number(firstElement.val()) - Number(secondElement.val()));
        }
    }
}