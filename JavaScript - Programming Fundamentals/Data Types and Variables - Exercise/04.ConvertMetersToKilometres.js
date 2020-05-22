function convertMtoKm(distance) {

    let distanceInMeters = Number(distance);
    let distanceInKm = distanceInMeters / 1000;

    console.log(distanceInKm.toFixed(2));
}