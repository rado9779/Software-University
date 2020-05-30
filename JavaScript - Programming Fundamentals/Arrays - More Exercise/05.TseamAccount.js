function tseam(input) {
    
    let games = input.shift().split(' ');

    while (true) {
        
        let commandLine = input.shift().split(' ');
        let command = commandLine[0];
        let game = commandLine[1];

        if (command === "Play!") {
            break;
        }
        else if(command === "Install"){

            if (!games.includes(game)) {
                games.push(game);
            }
        }
        else if(command === "Uninstall"){

            if (games.includes(game)) {

                let index = games.indexOf(game);
                games.splice(index,1);
            }
        }
        else if(command === "Update"){

            if (games.includes(game)) {

                let index = games.indexOf(game);
                games.splice(index,1);
                games.push(game);
            }
        }
        else if(command === "Expansion"){

            let gameAndExpansion = game.split('-');
            let gameToAdd = gameAndExpansion[0];
 
            if (games.includes(gameToAdd)) {
                let expandedGame = gameAndExpansion.join(':');
                let index = games.indexOf(gameToAdd);
                games.splice(index + 1, 0, expandedGame);
            }
        }
    }

    console.log(games.join(' '));
}