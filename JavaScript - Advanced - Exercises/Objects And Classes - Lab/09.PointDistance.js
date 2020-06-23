class Point {

    constructor(X, Y) {
        this.X = X;
        this.Y = Y;
    }

    static distance(p1, p2) {

        let sideA = p1.X - p2.X;
        let sideB = p1.Y - p2.Y;

        return Math.sqrt(sideA * sideA + sideB * sideB);
    }
}