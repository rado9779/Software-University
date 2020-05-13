function magicNumbers(input){

    let start = Number(input.shift());
    let end = Number(input.shift());
    let magicNumber = Number(input.shift());

    let combinations = 0;
    let isFound = false;

    for (let i = start; i <= end; i++) {
        
        for (let j = start; j <= end; j++) {
            
            combinations++;
            let result = i + j;

            if (result == magicNumber) {
                isFound = true;
                console.log(`Combination N:${combinations} (${i} + ${j} = ${result})`);
                return;
            }
        }
    }

    if (isFound == false) {
        console.log(`${combinations} combinations - neither equals ${magicNumber}`);
    }
}

