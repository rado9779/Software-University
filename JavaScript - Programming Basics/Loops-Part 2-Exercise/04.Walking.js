function dailySteps(input) {

    let target = 10000;
    let totalSteps = 0;

    while (true) {
        let command = input.shift();

        if (command == "Going home") {
            let steps = Number(input.shift());
            totalSteps += steps;

            if (totalSteps < target) {
                console.log(`${target - totalSteps} more steps to reach goal.`);
            }
            else {
                console.log(`Goal reached! Good job!`);
            }
            return;
        }

        let steps = Number(command);
        totalSteps += steps;

        if (totalSteps >= target) {
            console.log(`Goal reached! Good job!`);
            return;
        }
    }
}

