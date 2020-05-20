function replaceUnderscore(firstText, char, secondText) {

    let replaced = firstText.replace('_', char);

    if (replaced === secondText) {
        console.log("Matched");
    }
    else {
        console.log("Not Matched");
    }
}
