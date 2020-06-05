class Kitchen {

    constructor(budget) {
        this.budget = budget;
        this.menu = {};
        this.productsInStock = {};
        this.actionsHistory = [];
    }

    loadProducts(input) {

        let output = []

        for (let line of input) {

            line = line.split(' ')
            let price = Number(line.pop());
            let quantity = Number(line.pop());
            let product = line.join(' ')

            if (this.budget - price >= 0) {

                if (this.productsInStock[product]) {
                    this.productsInStock[product] += quantity;
                }
                else {
                    this.productsInStock[product] = quantity;
                }

                this.budget -= price;
                output.push(`Successfully loaded ${quantity} ${product}`);
            }
            else {
                output.push(`There was not enough money to load ${quantity} ${product}`);
            }
        }

        this.actionsHistory = [...this.actionsHistory, ...output];
        return this.actionsHistory.join('\n');
    }

    addToMenu(meal, neededProducts, price) {

        if (!this.menu[meal]) {
            this.menu[meal] = { products: neededProducts, price: Number(price) };
            return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals on the menu, other ideas?`;
        }
        else {
            return `The ${meal} is already in our menu, try something different.`;
        }
    }

    showTheMenu() {

        let output = [];

        for (let item of Object.keys(this.menu)) {
            output.push(`${item} - $ ${this.menu[item].price}`);
        }

        if (!output.length) {
            return ('Our menu is not ready yet, please come later...');
        }
        else {
            return output.join('\n') + '\n';
        }
    }

    makeTheOrder(meal) {

        if (!this.menu[meal]) {
            return (`There is not ${meal} yet in our menu, do you want to order something else?`);
        }

        let ingredients = this.menu[meal].products;

        for (let item of ingredients) {

            item = item.split(' ');
            let quantity = Number(item.pop());
            let product = item.join(' ');

            if (this.productsInStock[product] < quantity || !this.productsInStock[product]) {
                return (`For the time being, we cannot complete your order (${meal}), we are very sorry...`);
            }
        }

        for (let item of ingredients) {

            item = item.split(' ');
            let quantity = Number(item.pop());
            let product = item.join(' ');
            this.productsInStock[product] -= quantity;
        }

        this.budget += this.menu[meal].price;
        return (`Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`);
    }
}