function pyramidMaterials(base, increment) {

    let totalStone = 0;
    let totalMarble = 0;
    let totalLapis = 0;
    let totalGold = 0;
    let row = 0;

    let currentbase = base;

    while (currentbase > 2) {

        let marbel = currentbase * 4 - 4;
        let stone = currentbase * currentbase - marbel;

        totalStone += stone;
        row++;

        if (row % 5 === 0) {
            totalLapis += marbel;
        }
        else {
            totalMarble += marbel;
        }
        currentbase -= 2;
    }
    row++;

    let gold = currentbase * currentbase;

    let stone = Math.ceil(totalStone * increment);
    let marble = Math.ceil(totalMarble * increment);
    let lapis = Math.ceil(totalLapis * increment);
    let totalHeight = Math.floor(row * increment);

    totalGold = Math.ceil(gold * increment);

    console.log(`Stone required: ${stone}`);
    console.log(`Marble required: ${marble}`);
    console.log(`Lapis Lazuli required: ${lapis}`);
    console.log(`Gold required: ${totalGold}`);
    console.log(`Final pyramid height: ${totalHeight}`);
}