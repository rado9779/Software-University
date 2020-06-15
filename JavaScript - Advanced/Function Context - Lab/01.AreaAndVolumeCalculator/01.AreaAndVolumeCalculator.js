function solve(area, volume, input) {

    let objects = JSON.parse(input);

    function calculate(object) {

        let areaObject = Math.abs(area.call(object));
        let volumeObject = Math.abs(volume.call(object));

        return {
            area: areaObject,
            volume: volumeObject
        }
    }

    return objects.map(calculate);
}
