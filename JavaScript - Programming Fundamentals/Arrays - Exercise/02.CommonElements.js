function commonElementsInArrays(firstArray, secondArray) {

    for (const firstArrElement of firstArray) {

        for (const secondArrElement of secondArray) {

            if (firstArrElement === secondArrElement) {
                console.log(firstArrElement);
            }
        }
    }
}