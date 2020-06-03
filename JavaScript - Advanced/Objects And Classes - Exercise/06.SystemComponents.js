function systemComponents(input) {

    let result = new Map();

    for (let line of input) {

        let tokens = line.split(/\s*\|\s*/);
        let systemName = tokens[0];
        let componentName = tokens[1];
        let subcomponentName = tokens[2];

        if (!result.get(systemName)) {
            result.set(systemName, new Map());
        }
        if (!result.get(systemName).get(componentName)) {
            result.get(systemName).set(componentName, [])
        }
        result.get(systemName).get(componentName).push(subcomponentName);
    }

    let sortedSystems = Array.from(result.keys()).sort((a, b) => sortSystems(a, b));

    for (let system of sortedSystems) {

        console.log(system);
        let sortedComponent = Array.from(result.get(system).keys()).sort((a, b) => sortComponents(system, a, b));

        for (let component of sortedComponent) {
            console.log(`|||${component}`);
            result.get(system).get(component).forEach(x => console.log(`||||||${x}`))
        }
    }

    function sortSystems(a, b) {
        if (result.get(a).size != result.get(b).size) {
            return result.get(b).size - result.get(a).size;
        }
        else {
            return a.toLowerCase().localeCompare(b.toLowerCase());
        }
    }

    function sortComponents(system, a, b) {
        return result.get(system).get(b).length - result.get(system).get(a).length;
    }
}