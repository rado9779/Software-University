function solve(inputKingdoms, battles) {

    let kingdoms = {};

    for (let element of inputKingdoms) {

        let kingdomName = element.kingdom;
        let generalName = element.general;
        let army = Number(element.army);

        if (!kingdoms.hasOwnProperty(kingdomName)) {

            kingdoms[kingdomName] = { [generalName]: { army, wins: 0, losses: 0 } };
        }
        else {

            if (kingdoms[kingdomName].hasOwnProperty([generalName])) {
                kingdoms[kingdomName][generalName].army += army;
            }
            else {
                kingdoms[kingdomName][generalName] = { army, wins: 0, losses: 0 };
            }
        }
    }

    for (let element of battles) {

        let attackKingdom = element[0];
        let attackGeneral = element[1];
        let deffendKingdom = element[2];
        let deffendGeneral = element[3];
        let armyAttack = 0;
        let armyDeffend = 0;

        if (kingdoms.hasOwnProperty(attackKingdom) && kingdoms.hasOwnProperty(deffendKingdom)) {

            if (kingdoms[attackKingdom].hasOwnProperty(attackGeneral) &&
                kingdoms[deffendKingdom].hasOwnProperty(deffendGeneral) &&
                kingdoms[attackKingdom] !== kingdoms[deffendKingdom]) {

                armyAttack = kingdoms[attackKingdom][attackGeneral].army;
                armyDeffend = kingdoms[deffendKingdom][deffendGeneral].army;
            }
        }

        if (armyAttack > armyDeffend) {
            kingdoms[attackKingdom][attackGeneral].army = Math.floor(armyAttack + armyAttack * 0.1);
            kingdoms[attackKingdom][attackGeneral].wins += 1;
            kingdoms[deffendKingdom][deffendGeneral].army = Math.floor(armyDeffend - armyDeffend * 0.1);
            kingdoms[deffendKingdom][deffendGeneral].losses += 1;
        }
        else if (armyAttack < armyDeffend) {
            kingdoms[deffendKingdom][deffendGeneral].army = Math.floor(armyDeffend + armyDeffend * 0.1);
            kingdoms[deffendKingdom][deffendGeneral].wins += 1;
            kingdoms[attackKingdom][attackGeneral].army = Math.floor(armyAttack - armyAttack * 0.1);
            kingdoms[attackKingdom][attackGeneral].losses += 1;
        }
    }

    let orderedKingdoms = Object.keys(kingdoms).sort((a, b) =>
        getTotal(kingdoms[b], 'wins') - getTotal(kingdoms[a], 'wins') ||
        getTotal(kingdoms[a], 'losses') - getTotal(kingdoms[b], 'losses') ||
        a.localeCompare(b)
    );

    let winner = orderedKingdoms[0];
    console.log(`Winner: ${winner}`);

    let generals = Object.keys(kingdoms[winner]).sort((a, b) => kingdoms[winner][b].army - kingdoms[winner][a].army);

    generals.forEach(general => {
        let info = kingdoms[winner][general];
        console.log(`/\\general: ${general}`);
        console.log(`---army: ${info.army}`);
        console.log(`---wins: ${info.wins}`);
        console.log(`---losses: ${info.losses}`);
    });

    function getTotal(kingdom, type) {
        return Object.keys(kingdom).reduce((x, y) => (x + kingdom[y][type]), 0);
    }
}