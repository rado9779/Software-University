function argumentsInfo(...input) {

    let result = {};

    for (const item of input) {
        let type = typeof (item);

        console.log(`${type}: ${item}`);

        if (result[type] === undefined) {
            result[type] = 0;
        }
        result[type]++;
    }

    Object.entries(result)
          .sort((a, b) => b[1] - a[1])
          .forEach(x => console.log(`${x[0]} = ${x[1]}`));
}
