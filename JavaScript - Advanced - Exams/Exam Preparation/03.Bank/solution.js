class Bank {

    constructor(bankName) {
        this._bankName = bankName;
        this.allCustomers = [];
    }

    newCustomer({ firstName, lastName, personalId }) {

        if (this.allCustomers.find(x => x.firstName === firstName && x.lastName === lastName && x.personalId === personalId)) {
            throw new Error(`${firstName} ${lastName} is already our customer!`);
        }

        this.allCustomers.push({ firstName, lastName, personalId });
        return { firstName, lastName, personalId };
    }

    depositMoney(personalId, amount) {

        const customer = this.allCustomers.find(x => x.personalId === personalId)

        if (!customer) {
            throw new Error('We have no customer with this ID!');
        }

        if (customer.totalMoney === undefined) {
            customer.totalMoney = amount;
            customer.transactions = [];
        }
        else {
            customer.totalMoney += amount;
        }

        customer.transactions.push({ type: 'deposit', amount: amount });
        return `${customer.totalMoney}$`;
    }

    withdrawMoney(personalId, amount) {
        const customer = this.allCustomers.find(x => x.personalId === personalId)

        if (!customer) {
            throw new Error('We have no customer with this ID!');
        }

        if (customer.totalMoney < amount) {
            throw new Error(`${customer.firstName} ${customer.lastName} does not have enough money to withdraw that amount!`);
        }

        customer.totalMoney -= amount;
        customer.transactions.push({ type: 'withdrew', amount: amount });
        return `${customer.totalMoney}$`;
    }

    customerInfo(personalId) {
        const customer = this.allCustomers.find(x => x.personalId === personalId)

        if (!customer) {
            throw new Error('We have no customer with this ID!');
        }

        let result = '';
        result += `Bank name: ${this._bankName}\n`;
        result += `Customer name: ${customer.firstName} ${customer.lastName}\n`;
        result += `Customer ID: ${customer.personalId}\n`;
        result += `Total Money: ${customer.totalMoney}$\n`;

        let n = customer.transactions.length;

        if (n > 0) {
            result += `Transactions:\n`;

            const reversed = customer.transactions.reverse();

            for (const index in reversed) {

                const type = customer.transactions[index].type;
                const amount = customer.transactions[index].amount;

                if (type === 'deposit') {
                    result += `${n}. ${customer.firstName} ${customer.lastName} made ${type} of ${amount}$!\n`;
                }
                else {
                    result += `${n}. ${customer.firstName} ${customer.lastName} ${type} ${amount}$!\n`;
                }
                n--;
            }
        }

        return result.trimEnd();
    }
}