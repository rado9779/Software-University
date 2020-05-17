function verySpecialNumbers(startNumber, endNumber, nNumber) {

    let start = Number(startNumber);
    let end = Number(endNumber);
    let n = Number(nNumber);

    for (let i = start; i <= end; i++) {

        if (i % (n * n) === 0) {
            
            console.log(`Very special number: ${i}`);
        }
        else if (i % n === 0) {

            console.log(`Special number: ${i}`);
        }
        else 
        {
            console.log(i);
        }
    }
}