function stringParameters(firstString, secondString, thirdString) {

    let firstLength = firstString.length;
    let secondLength = secondString.length;
    let thirdLength = thirdString.length;

    let sumLength = firstLength + secondLength + thirdLength;
    let averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}
