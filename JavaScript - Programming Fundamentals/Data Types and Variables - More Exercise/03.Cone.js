function coneParameters(coneRadius, coneHeight) {

    let radius = Number(coneRadius);
    let height = Number(coneHeight);

    let volume = Math.PI * radius * radius * height / 3;
    let slantLength = Math.sqrt(radius * radius + height * height);
    let area = Math.PI * radius * (radius + slantLength);

    console.log(`volume = ${volume.toFixed(4)}`);
    console.log(`area = ${area.toFixed(4)}`);
}
