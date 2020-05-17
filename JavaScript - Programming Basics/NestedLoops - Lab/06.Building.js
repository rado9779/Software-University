function roomsNumbers(input) {

    let floors = Number(input.shift());
    let roomsPerFloor = Number(input.shift());

    for (let floor = floors; floor >= 1; floor--) {

        let result = "";
        for (let room = 0; room < roomsPerFloor; room++) {

            if (floor == floors) {
                result += `L${floor}${room} `;
            }
            else if (floor % 2 == 0) {
                result += `O${floor}${room} `;
            }
            else {
                result += `A${floor}${room} `;
            }
        }
        console.log(result);
    }
}
