class VeterinaryClinic {

    constructor(clinicName, capacity) {
        this.clinicName = clinicName;
        this.capacity = capacity;
        this.clients = [];
        this.totalProfit = 0;
        this.currentWorkload = 0;
    }

    list = {};

    newCustomer(ownerName, petName, kind, procedures) {
        const clientsNumber = this.clients.length;

        if (clientsNumber === this.capacity) {
            throw new Error('Sorry, we are not able to accept more patients!');
        }

        if (this.list[ownerName] === undefined) {
            this.list[ownerName] = [];
        }

        const pet = this.list[ownerName].find(x => x.petName === petName);

        if (pet && pet.procedures.length > 0) {
            throw new Error(`This pet is already registered under ${this.ownerName} name! ${pet.petName} is on our lists, waiting for ${pet.procedures.join(', ')}.`);
        }

        this.list[ownerName].push({ petName, kind, procedures });
        this.clients.push(ownerName);
        this.currentWorkload++;
        return `Welcome ${petName}!`;
    }

    onLeaving(ownerName, petName) {
        if (this.clients.includes(ownerName) === false) {
            throw new Error('Sorry, there is no such client!');
        }

        const pet = this.list[ownerName].find(x => x.petName === petName);
        if (pet === undefined || pet.procedures <= 0) {
            throw new Error(`"Sorry, there are no procedures for ${petName}!"`);
        }

        const bill = pet.procedures.length * 500;
        this.currentWorkload--;
        pet.procedures.length = 0;
        this.totalProfit += bill;

        return `Goodbye ${pet.petName}. Stay safe!`;
    }

    toString() {
     
    }
}


let clinic = new VeterinaryClinic('SoftCare', 10);
console.log(clinic.newCustomer('Jim Jones', 'Tom', 'Cat', ['A154B', '2C32B', '12CDB']));
console.log(clinic.newCustomer('Anna Morgan', 'Max', 'Dog', ['SK456', 'DFG45', 'KS456']));
console.log(clinic.newCustomer('Jim Jones', 'Tiny', 'Cat', ['A154B']));
console.log(clinic.onLeaving('Jim Jones', 'Tiny'));
console.log(clinic.toString());
clinic.newCustomer('Jim Jones', 'Sara', 'Dog', ['A154B']);
console.log(clinic.toString());

