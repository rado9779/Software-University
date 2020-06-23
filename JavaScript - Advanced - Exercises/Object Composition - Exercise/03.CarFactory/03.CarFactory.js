function factory(input) {

    let enginePower = () => {

        if (input.power <= 90) {
            return 90;
        }
        else if (input.power <= 120) {
            return 120;
        }
        else {
            return 200;
        }
    };

    let engineVolume = () => {

        if (input.power <= 90) {
            return 1800;
        }
        else if (input.power <= 120) {
            return 2400;
        }
        else {
            return 3500;
        }
    };

    let wheels = () => {
        let wheelsize = input.wheelsize;

        if (wheelsize % 2 === 0) {
            wheelsize -= 1;
        }

        return [wheelsize, wheelsize, wheelsize, wheelsize];
    };

    let car = {
        model: input.model,
        engine: {
            power: enginePower(),
            volume: engineVolume()
        },
        carriage: {
            type: input.carriage,
            color: input.color
        },
        wheels: wheels()
    }

    return car;
}