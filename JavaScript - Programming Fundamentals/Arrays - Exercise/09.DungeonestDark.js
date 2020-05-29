function playGame(input) {

    let health = 100;
    let coins = 0;

    let rooms = input[0].split('|');

    for (let dungeon = 0; dungeon < rooms.length; dungeon++) {

        let tokens = rooms[dungeon].split(' ');
        let command = tokens[0];
        let value = Number(tokens[1]);

        if (command === "potion") {

            let neededHeal = 100 - health;

            if (value > neededHeal) {
                value = neededHeal;
            }

            health += value;

            console.log(`You healed for ${value} hp.`);
            console.log(`Current health: ${health} hp.`);
        }
        else if (command === "chest") {

            coins += value;
            console.log(`You found ${value} coins.`);
        }
        else {

            health -= value;

            if (health <= 0) {
                console.log(`You died! Killed by ${command}.`);
                console.log(`Best room: ${dungeon + 1}`);
                return;
            }

            console.log(`You slayed ${command}.`);
        }
    }

    console.log("You've made it!");
    console.log(`Coins: ${coins}`);
    console.log(`Health: ${health}`);
}