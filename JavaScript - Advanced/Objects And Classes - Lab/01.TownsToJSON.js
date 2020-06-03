function convertToJSON(input) {

    let towns = [];
    let regex = /\s*\|\s*/;

    for (let row = 1; row < input.length; row++) {

        let line = input[row].split(regex);
        let townName = line[1];
        let latitude = Number(line[2]).toFixed(2);
        let = longitude = Number(line[3]).toFixed(2);
        let object = { Town: townName, Latitude: Number(latitude), Longitude: Number(longitude) };
        towns.push(object);
    }

    let result = JSON.stringify(towns);
    console.log(result);
}
