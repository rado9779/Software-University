function townsPopulation(input) {

    let result = new Map();

    for (let i = 0; i < input.length; i++) {

        let splittedLine = input[i].split(" <-> ");

        let town = splittedLine[0];
        let population = Number(splittedLine[1]);

        if (result.has(town)) {
            result.set(town, result.get(town) + population);
        }
        else {
            result.set(town, population);
        }
    }

    for (const [key, value] of result) {
        console.log(`${key} : ${value}`);
    }
}
