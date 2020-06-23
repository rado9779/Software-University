function heroicInventory(input) {

    let result = [];

    for (const line of input) {

        let tokens = line.split(" / ");

        let name = tokens[0];
        let level = Number(tokens[1]);
        let items = [];

        if (tokens.length > 2) {
            items = tokens[2].split(', ');
        }

        let hero = { name, level, items };
        result.push(hero);
    }

    let resultToJSON = JSON.stringify(result);
    console.log(resultToJSON);
}