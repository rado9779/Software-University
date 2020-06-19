function solution(input) {

    class Rectangle {
        constructor(width, height) {
            this.width = width;
            this.height = height;
        }

        area() {
            return this.width * this.height;
        }

        compareTo(other) {
            return other.area() - this.area() || other.width - this.width;
        }
    }

    let result = [];

    for (const [width, height] of input) {
        result.push(new Rectangle(width, height));
    }

    let sortedResult = result.sort((a, b) => a.compareTo(b));
    return sortedResult;
}