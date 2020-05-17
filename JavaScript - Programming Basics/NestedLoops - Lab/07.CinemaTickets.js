function cinemaTickets(input) {

    let movie = input.shift();

    let totalTickets = 0;
    let studentCount = 0;
    let standardCount = 0;
    let kidsCount = 0;

    while (true) {

        if (movie == "Finish") {
            break;
        }

        let seats = Number(input.shift());
        let ticket = input.shift();
        let soldTickets = 0;

        while (true) {

            if (ticket == "End") {
                break;
            }
            else if (ticket === 'student') {
                studentCount++;
            }
            else if (ticket === 'standard') {
                standardCount++;
            }
            else {
                kidsCount++;
            }
            totalTickets++;
            soldTickets++;

            if (soldTickets >= seats) {
                break;
            }
            ticket = input.shift();
        }

        console.log(`${movie} - ${((soldTickets / seats) * 100).toFixed(2)}% full.`);
        movie = input.shift();
    }

    console.log(`Total tickets: ${totalTickets}`);
    console.log(`${((studentCount / totalTickets) * 100).toFixed(2)}% student tickets.`);
    console.log(`${((standardCount / totalTickets) * 100).toFixed(2)}% standard tickets.`);
    console.log(`${((kidsCount / totalTickets) * 100).toFixed(2)}% kids tickets.`);
}