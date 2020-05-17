function volleyballGames(year, holidaysCount, weekendsCount) {

    let holidays = Number(holidaysCount);
    let gamesInHomeTown = Number(weekendsCount);

    let gamesInSofia = (48 - gamesInHomeTown) * (3.0 / 4.0);
    let gamesDuringHolidays = holidays * (2.0 / 3.0);

    let totalGames = gamesInHomeTown + gamesInSofia + gamesDuringHolidays;

    if (year == "leap") {
        totalGames *= 1.15;
    }

    console.log(Math.floor(totalGames));
}



