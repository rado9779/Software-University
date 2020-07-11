const expect = require('chai').expect;
const mathEnforcer = require('../03.MathEnforcer');

describe('mathEnforcer', function () {

    describe('addFive', function () {

        it('should return undefined with string input', function () {
            const result = mathEnforcer.addFive('number');
            expect(result).to.be.undefined;
        });

        it('should return undefined with object input', function () {
            const result = mathEnforcer.addFive({ Input: 'number' });
            expect(result).to.be.undefined;
        });

        it('should add five to integer number input correctly', function () {
            const result = mathEnforcer.addFive(5);
            expect(result).to.be.equal(10);
        });

        it('should add five to floating-point number input correctly', function () {
            const result = mathEnforcer.addFive(5.5);
            expect(result).to.be.equal(10.5);
        });

        it('should add five to negative number input correctly', function () {
            const result = mathEnforcer.addFive(-5);
            expect(result).to.be.equal(0);
        });
    });

    describe('subtractTen', function () {

        it('should return undefined with string input', function () {
            const result = mathEnforcer.subtractTen('number');
            expect(result).to.be.undefined;
        });

        it('should return undefined with object input', function () {
            const result = mathEnforcer.subtractTen({ Input: 'number' });
            expect(result).to.be.undefined;
        });

        it('should subtract ten from integer number input correctly', function () {
            const result = mathEnforcer.subtractTen(50);
            expect(result).to.be.equal(40);
        });

        it('should subtract ten from floating-point number input correctly', function () {
            const result = mathEnforcer.subtractTen(55.5);
            expect(result).to.be.equal(45.5);
        });

        it('should subtract ten from negative number input correctly', function () {
            const result = mathEnforcer.subtractTen(-50);
            expect(result).to.be.equal(-60);
        });
    });

    describe('sum', function () {

        it('should return undefined with string input as first parameter', function () {
            const result = mathEnforcer.sum('number', 2);
            expect(result).to.be.undefined;
        });

        it('should return undefined with string input as second parameter', function () {
            const result = mathEnforcer.sum(1, 'number');
            expect(result).to.be.undefined;
        });

        it('should return undefined with object input as first parameter', function () {
            const result = mathEnforcer.sum({ Input: 'number' }, 2);
            expect(result).to.be.undefined;
        });

        it('should return undefined with object input as second parameter', function () {
            const result = mathEnforcer.sum(1, { Input: 'number' });
            expect(result).to.be.undefined;
        });

        it('should return correct sum of integers numbers with correct input parameters', function () {
            const result = mathEnforcer.sum(1, 2);
            expect(result).to.be.equal(3);
        });

        it('should return correct sum of floating-point numbers with correct input parameters', function () {
            const result = mathEnforcer.sum(5.5, 5.5);
            expect(result).to.be.equal(11);
        });

        it('should return correct sum of negative numbers with correct input parameters', function () {
            const result = mathEnforcer.sum(-5, -5);
            expect(result).to.be.equal(-10);
        });
    });
});