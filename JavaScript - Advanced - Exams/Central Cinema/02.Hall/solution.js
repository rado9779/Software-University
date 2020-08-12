function solveClasses() {

    class Hall {
        constructor(capacity, name) {
            this.capacity = Number(capacity);
            this.name = name;
            this.events = [];
        }

        hallEvent(title) {
            if (this.events.includes(title)) {
                throw new Error("This event is already added!");
            }

            this.events.push(title);
            return "Event is added.";
        }

        close() {
            this.events = [];
            return `${this.name} hall is closed.`;
        }

        toString() {
            let result = '';
            result += `${this.name} hall - ${this.capacity}\n`;
            if (this.events.length > 0) {
                result += `Events: ${this.events.join(', ')}\n`;
            }
            return result.trimEnd();
        }
    }

    class MovieTheater extends Hall {
        constructor(capacity, name, screenSize) {
            super(capacity, name);
            this.events = [];
            this.screenSize = screenSize;
        }

        close() {
            let result = '';
            result += `${super.close()}Аll screenings are over.\n`;
            return result.trimEnd();
        }

        toString() {
            let result = '';
            result += `${super.toString()}\n`;
            result += `${this.name} is a movie theater with ${this.screenSize} screensize and ${this.capacity} seats capacity.\n`;
            return result.trimEnd();
        }
    }

    class ConcertHall extends Hall {

        constructor(capacity, name) {
            super(capacity, name);
            this.events = [];
            this.performers = [];
        }

        hallEvent(title, performers) {
            if (this.events.includes(title)) {
                throw new Error("This event is already added!");
            }

            this.events.push(title);
            this.performers.push(performers);
            return "Event is added.";
        }

        close() {
            this.performers = [];
            let result = '';
            result += `${super.close()}Аll performances are over.\n`;
            return result.trimEnd();
        }

        toString() {
            let result = '';
            result += `${super.toString()}\n`;
            if (this.performers.length > 0) {
                result += `Performers: ${this.performers.join(', ')}.\n`;
            }
            return result.trimEnd();
        }
    }

    return {
        Hall,
        MovieTheater,
        ConcertHall
    }
}