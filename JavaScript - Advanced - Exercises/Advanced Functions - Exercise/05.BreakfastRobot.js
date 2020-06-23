function solution() {

    const storage = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    }

    const recipes = {
        apple: {
            carbohydrate: 1,
            flavour: 2,
            order: ['carbohydrate', 'flavour']
        },
        lemonade: {
            carbohydrate: 10,
            flavour: 20,
            order: ['carbohydrate', 'flavour']
        },
        burger: {
            carbohydrate: 5,
            fat: 7,
            flavour: 3,
            order: ['carbohydrate', 'fat', 'flavour']
        },
        eggs: {
            protein: 5,
            fat: 1,
            flavour: 1,
            order: ['protein', 'fat', 'flavour']
        },
        turkey: {
            protein: 10,
            carbohydrate: 10,
            fat: 10,
            flavour: 10,
            order: ['protein', 'carbohydrate', 'fat', 'flavour']

        }
    };

    const operations = {
        restock,
        prepare,
        report
    }

    function restock(microelement, quantity) {
        storage[microelement] += quantity;
        return 'Success';
    }

    function prepare(recipe, quantity) {

        const required = Object.assign({}, recipes[recipe]);
        required.order.forEach(key => required[key] *= quantity);

        for (let element of required.order) {
            if (storage[element] < required[element]) {
                if (storage[element] < required[element]) {
                    return `Error: not enough ${element} in stock`;
                }
            }
        }

        required.order.forEach(x => storage[x] -= required[x]);
        return 'Success';
    }

    function report() {
        return `protein=${storage.protein} carbohydrate=${storage.carbohydrate} fat=${storage.fat} flavour=${storage.flavour}`;
    }

    function manager(command) {
        const tokens = command.split(' ');
        return operations[tokens[0]](tokens[1], Number(tokens[2]));
    }

    return manager;
}