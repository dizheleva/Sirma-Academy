class Ticket {
    constructor(destination, price, status) {
        this.destination = destination;
        this.price = price;
        this.status = status;
    }
}

function solve(inputData, sorting) {
    let tickets = [];

    inputData.forEach(line => {
        let [destinationName, price, status] = line.split('|');
        let ticket = new Ticket(destinationName, price, status);
        tickets.push(ticket);
    });

    tickets.sort((a, b) => {
        if (sorting === 'price') {
            return a[sorting] - b[sorting];
        } else {
            return a[sorting].localeCompare(b[sorting]);
        }        
    });
    
    for (const ticket of tickets) {
        console.log(ticket);
    }
}

solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination');

solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'status');