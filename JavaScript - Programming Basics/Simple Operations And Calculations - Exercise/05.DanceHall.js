function dancersInHall(length,width,side){

    let l = Number(length);
    let w = Number(width);
    let a = Number(side);

    let roomArea = (l * 100) * (w * 100);
    let wardrobeSize = (a * 100) * (a * 100);
    let benchSize = roomArea / 10;
    let space = roomArea - wardrobeSize - benchSize;
    let dancers = space / (40 + 7000);
    
    console.log(Math.floor(dancers));
}

