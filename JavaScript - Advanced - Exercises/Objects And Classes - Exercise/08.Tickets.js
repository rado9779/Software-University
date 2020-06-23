function ticketSystem(tickets, criterion) {

    let result = [];

    for (const line of tickets) {

        let tokens = line.split('|');
        let destinationName = tokens[0];
        let price = Number(tokens[1]);
        let status = tokens[2];

        let ticket = { destination: destinationName, price: price, status: status };
        result.push(ticket);
    }

    let sortedResult;

    switch (criterion) {
        case "destination":
            sortedResult = result.sort((a, b) => a.destination.localeCompare(b.destination));
            break;
        case "price":
            sortedResult = result.sort((a, b) => a.price - b.price);
            break;
        case "status":
            sortedResult = result.sort((a, b) => a.status.localeCompare(b.status));
            break;
    }

    return sortedResult;
}