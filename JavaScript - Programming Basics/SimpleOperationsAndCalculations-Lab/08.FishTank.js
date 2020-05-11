function litersInTank(length, width, heightInCM, percent) {


    let tankVolumeInCm = length * width * heightInCM;
    let tankLiters = tankVolumeInCm / 1000;
    let waste = percent / 100;
    let totalResult = tankLiters * (1 - waste);

    console.log(totalResult.toFixed(3));
}
