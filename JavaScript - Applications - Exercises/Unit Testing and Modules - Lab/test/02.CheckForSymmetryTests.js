const expect = require('chai').expect;
const isSymmetric = require('../02.CheckForSymmetry');

describe('isSymmetric', function () {

    it('should return false if input isn’t correct type', function () {
        const input = 'input';
        const result = isSymmetric(input);
        expect(result).to.be.false;
    });

    it('should return true if input array is symmetric', function () {
        const input = [1, 2, 2, 1];
        const result = isSymmetric(input);
        expect(result).to.be.true;
    });

    it('should return false if input array is not symmetric', function () {
        const input = [2, 1, 2, 1];
        const result = isSymmetric(input);
        expect(result).to.be.false;
    });
});