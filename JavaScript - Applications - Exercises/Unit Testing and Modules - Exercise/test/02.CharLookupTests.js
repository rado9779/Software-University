const expect = require('chai').expect;
const lookupChar = require('../02.CharLookup');

describe('lookupChar', function () {

    it('should return undefined with integer number input as first parameter', function () {
        const result = lookupChar(1, 0);
        expect(result).to.be.equal(undefined);
    });

    it('should return undefined with string input as second parameter', function () {
        const result = lookupChar('a', 'b');
        expect(result).to.be.equal(undefined);
    });

    it('should return undefined with floating-point number input as second parameter', function () {
        const result = lookupChar('string', 5.5);
        expect(result).to.be.equal(undefined);
    });

    it('should return "Incorrect index" with number bigger than string length input as second parameter', function () {
        const result = lookupChar('string', 55);
        expect(result).to.be.equal('Incorrect index');
    });

    it('should return "Incorrect index" with negative number input as second parameter', function () {
        const result = lookupChar('string', -5);
        expect(result).to.be.equal('Incorrect index');
    });

    it('should return "Incorrect index" with number equal to string length input as second parameter', function () {
        const result = lookupChar('string', 6);
        expect(result).to.be.equal('Incorrect index');
    });

    it('should return first char of string with correct input parameters', function () {
        const result = lookupChar('string', 0);
        expect(result).to.be.equal('s');
    });

    it('should return last char of string with correct input parameters', function () {
        const result = lookupChar('string', 5);
        expect(result).to.be.equal('g');
    });
});