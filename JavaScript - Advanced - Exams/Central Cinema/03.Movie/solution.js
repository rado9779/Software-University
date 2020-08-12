class Movie {

    constructor(movieName, ticketPrice) {
        this.movieName = movieName;
        this.ticketPrice = Number(ticketPrice);
        this.screenings = [];
        this.totalProfit = 0;
        this.totalTickets = 0;
    }

    newScreening(date, hall, description) {

        if (this.screenings.find(x => x.date === date && x.hall === hall)) {
            throw new Error(`Sorry, ${hall} hall is not available on ${date}`);
        }
        const projection = { date, hall, description };
        this.screenings.push(projection);
        return `New screening of ${this.movieName} is added.`;
    }

    endScreening(date, hall, soldTickets) {

        const projection = this.screenings.find(x => x.date === date && x.hall === hall);

        if (!projection) {
            throw new Error(`Sorry, there is no such screening for ${this.movieName} movie.`);
        }

        const currentProfit = this.ticketPrice * soldTickets;
        this.totalProfit += currentProfit;
        this.totalTickets += soldTickets;
        const index = this.screenings.indexOf(projection);
        this.screenings.splice(index, 1);

        return `${this.movieName} movie screening on ${date} in ${hall} hall has ended. Screening profit: ${currentProfit}`;
    }

    toString() {

        let result = '';
        result += `${this.movieName} full information:\n`;
        result += `Total profit: ${this.totalProfit.toFixed(0)}$\n`;
        result += `Sold Tickets: ${this.totalTickets.toFixed(0)}\n`;

        if (this.screenings.length > 0) {
            result += `Remaining film screenings:\n`;

            const sorted = this.screenings.sort((a, b) => a.hall.localeCompare(b.hall));

            for (const projection of sorted) {
                result += `${projection.hall} - ${projection.date} - ${projection.description}\n`;
            }
        }
        else {
            result += `No more screenings!\n`;
        }
        return result.trimEnd();
    }
}