function figures() {

    class Figure {
        constructor(units = 'cm') {
            this.units = units;
        }

        changeUnits(newUnits) {
            this.units = newUnits;
        }

        convertUnits(input) {

            if (this.units === 'mm') {
                return input * 10;
            }
            else if (this.units === 'm') {
                return input / 100;
            }
            return input;
        }

        toString() {
            throw new Error('"toString" is not Implemented!');
        }

        get area() {
            throw new Error('"area" is not Implemented!');
        }
    }

    class Circle extends Figure {

        constructor(radius, units) {
            super(units);
            this.radius = radius;
        }

        get area() {
            const radius = this.convertUnits(this.radius);
            return Math.PI * radius * radius;
        }

        toString() {
            const radius = this.convertUnits(this.radius);
            return `Figures units: ${this.units} Area: ${this.area} - radius: ${radius}`;
        }
    }

    class Rectangle extends Figure {

        constructor(width, height, units) {
            super(units);
            this.width = width;
            this.height = height;
        }

        get area() {
            const width = this.convertUnits(this.width);
            const height = this.convertUnits(this.height);
            return width * height;
        }

        toString() {
            const width = this.convertUnits(this.width);
            const height = this.convertUnits(this.height);
            return `Figures units: ${this.units} Area: ${this.area} - width: ${width}, height: ${height}`;
        }
    }

    return { Figure, Circle, Rectangle };
}