const expect = require('chai').expect;
const rgbToHexColor = require('../03.RGBtoHex');

describe('rgbToHexColor', function () {

    it('should return undefined if input parameters are null', function () {
        const result = rgbToHexColor();
        expect(result).to.be.undefined;
    })

    it('should return undefined if red is NaN', function () {
        const result = rgbToHexColor('red', 1, 1);
        expect(result).to.be.undefined;
    });

    it('should return undefined if green is NaN', function () {
        const result = rgbToHexColor(1, 'green', 1);
        expect(result).to.be.undefined;
    });

    it('should return undefined if blue is NaN', function () {
        const result = rgbToHexColor(1, 1, 'blue');
        expect(result).to.be.undefined;
    })

    it('should return undefined if red is out of range', function () {
        const result = rgbToHexColor(-1, 1, 1);
        expect(result).to.be.undefined;
    })

    it('should return undefined if green is out of range', function () {
        const result = rgbToHexColor(1, 256, 1);
        expect(result).to.be.undefined;
    })

    it('should return undefined if blue is out of range', function () {
        const result = rgbToHexColor(1, 1, -256);
        expect(result).to.be.undefined;
    })

    it('should return color in hexadecimal format as a string', function () {
        const expected = '#FFFFFF';
        const actual = rgbToHexColor(255, 255, 255);
        expect(actual).to.be.equal(expected);
    })
});