function solution(input) {

    let objectManager = (function () {

        let result = {};

        return {
            create: (name) => result[name] = {},
            createInheritance: (name, parentName) => result[name] = Object.create(result[parentName]),
            set: (name, key, value) => result[name][key] = value,
            print: (name) => {
                let output = [];

                for (const key in result[name]) {
                    output.push(`${key}:${result[name][key]}`);
                }

                console.log(output.join(', '));
            }
        }
    })();

    for (const line of input) {

        const splitted = line.split(' ');
        const name = splitted[1];

        if (splitted[0] === 'create') {

            if (splitted[2] === 'inherit') {
                const parent = splitted[3];
                objectManager.createInheritance(name, parent);
            }
            else {
                objectManager.create(name);
            }

        } else if (splitted[0] === 'set') {
            const key = splitted[2];
            const value = splitted[3];
            objectManager.set(name, key, value);
        }
        else {
            objectManager.print(name);
        }
    }
}