function arenaTier(input) {

    let gladiators = {}

    while (true) {

        let line = input.shift();

        if (line.includes("->")) {

            let tokens = line.split(" -> ");

            let gladiator = tokens[0];
            let technique = tokens[1];
            let skill = Number(tokens[2]);

            if (!gladiators.hasOwnProperty(gladiator)) {
                gladiators[gladiator] = { totalPoints: 0, techniques: {} };
            }

            if (!gladiators[gladiator]['techniques'].hasOwnProperty(technique)) {
                gladiators[gladiator]['techniques'][technique] = 0;
                gladiators[gladiator]["totalPoints"] += skill;
            }

            if (skill > gladiators[gladiator]['techniques'][technique]) {
                gladiators[gladiator]['techniques'][technique] = skill;

                let difference = skill - gladiators[gladiator]['techniques'][technique];
                gladiators[gladiator]["totalPoints"] += difference;
            }
        }
        else if (line.includes("vs")) {

            let tokens = line.split(" vs ");

            let firstGladiator = tokens[0];
            let secondGladiator = tokens[1];

            if (gladiators.hasOwnProperty(firstGladiator) && gladiators.hasOwnProperty(secondGladiator)) {

                let hasCommon = false;

                for (let firstGladiatorTechnique of Object.entries(gladiators[firstGladiator]['techniques'])) {

                    for (let secondGladiatorTechnique of Object.entries(gladiators[secondGladiator]['techniques'])) {

                        if (firstGladiatorTechnique[0] === secondGladiatorTechnique[0]) {
                            hasCommon = true;
                            break;
                        }
                    }
                    if (hasCommon) {
                        break;
                    }
                }

                if (hasCommon) {
                    if (gladiators[firstGladiator]["totalPoints"] > gladiators[secondGladiator]["totalPoints"]) {
                        delete gladiators[secondGladiator];
                    }
                    else if (gladiators[secondGladiator]["totalPoints"] > gladiators[firstGladiator]["totalPoints"]) {
                        delete gladiators[firstGladiator];
                    }
                }
            }
        }
        else if (line.includes("Ave Cesar")) {
            break;
        }
    }

    let result = Object.entries(gladiators).filter(x => x[1] !== null)
        .sort((a, b) => b[1]["totalPoints"] - a[1]["totalPoints"])
        .sort((a, b) => a[0] - b[0]);

    for (let gladiator of result) {
        console.log(`${gladiator[0]}: ${gladiator[1]["totalPoints"]} skill`);

        let sortedTechniques = Object.entries(gladiator[1]["techniques"])
            .sort((a, b) => b[1] - a[1])
            .sort((a, b) => a[0] - b[0]);

        for (let technique of sortedTechniques) {
            console.log(`- ${technique[0]} <!> ${technique[1]}`);
        }
    }
}