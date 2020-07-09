const expect = require('chai').expect;
const createCalculator = require('../04.AddOrSubtract');

describe('createCalculator', function () {

    it('should return an internal sum which can’t be modified from the outside', function () {
        const calculator = createCalculator();
        const result = calculator.value;
        expect(result).to.be.equal(undefined);
    });

    it('should add input number correctly', function () {
        const calculator = createCalculator();
        calculator.add(33);
        const result = calculator.get();
        expect(result).to.be.equal(33);
    });

    it('should add input string correctly', function () {
        const calculator = createCalculator();
        calculator.add('33');
        const result = calculator.get();
        expect(result).to.be.equal(33);
    });

    it('should subtract input number correctly', function () {
        const calculator = createCalculator();
        calculator.subtract(33);
        const result = calculator.get();
        expect(result).to.be.equal(-33);
    });

    it('should subtract input string correctly', function () {
        const calculator = createCalculator();
        calculator.subtract('33');
        const result = calculator.get();
        expect(result).to.be.equal(-33);
    });

    it('should return internal sum', function () {
        const calculator = createCalculator();
        const result = calculator.get();
        expect(result).to.be.equal(0);
    });
});