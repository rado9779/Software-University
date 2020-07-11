const expect = require('chai').expect;
const isOddOrEven = require('../01.EvenOrOdd');

describe('is Odd or Even', function () {

    it('should return undefined with number input', function () {
        const result = isOddOrEven(13);
        expect(result).to.be.equal(undefined);
    });

    it('should return undefined with object input', function () {
        const result = isOddOrEven({ Object: 'input' });
        expect(result).to.be.equal(undefined);
    });

    it('should return "even" with even length', function () {
        const result = isOddOrEven('evenLength');
        expect(result).to.be.equal('even');
    });

    it('should return "odd" with odd length', function () {
        const result = isOddOrEven('oddLength');
        expect(result).to.be.equal('odd');
    });

    it('should return correct values with multiple consecutive checks', function () {
        const firstResult = isOddOrEven('cat');
        expect(firstResult).to.be.equal('odd');

        const secondResult = isOddOrEven('elephant');
        expect(secondResult).to.be.equal('even');

        const thirdResult = isOddOrEven('lion');
        expect(thirdResult).to.be.equal('even');

        const fourthResult = isOddOrEven('tiger');
        expect(fourthResult).to.be.equal('odd');
    });
});