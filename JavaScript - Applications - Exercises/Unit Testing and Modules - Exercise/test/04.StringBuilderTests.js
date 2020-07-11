const expect = require('chai').expect;
const StringBuilder = require('../04.StringBuilder');

describe('StringBuilder', function () {
    let builder;

    it('should initialize correctly', function () {
        let withEmptyInput = () => builder = new StringBuilder();
        expect(withEmptyInput).to.not.throw();

        let withStringInput = () => builder = new StringBuilder('hello');
        expect(withStringInput).to.not.throw();
    });

    it('should throw exception with incorrect number input', function () {
        let withNumberInput = () => builder = new StringBuilder(5);
        expect(withNumberInput).to.throw();
    });

    describe('should initialize with empty constructor', function () {
        beforeEach(function () {
            builder = new StringBuilder();
        });

        it('has all properties', function () {
            expect(builder.hasOwnProperty('_stringArray')).to.equal(true, "Missing _stringArray property");
        });

        it('has functions attached to prototype', function () {
            expect(Object.getPrototypeOf(builder).hasOwnProperty('append')).to.equal(true, "Missing append function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('prepend')).to.equal(true, "Missing prepend function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('insertAt')).to.equal(true, "Missing insertAt function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('remove')).to.equal(true, "Missing remove function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('toString')).to.equal(true, "Missing toString function");
        });

        it('should initialize data to an empty array', function () {
            expect(builder._stringArray instanceof Array).to.equal(true, 'Data must be of type array');
            expect(builder._stringArray.length).to.equal(0, 'Data array must be initialized empty');
        });
    });

    describe('should initialize constructor with string parameter', function () {
        let string = 'hello';

        beforeEach(function () {
            builder = new StringBuilder(string);
        });

        it('must initialize data to a string array', function () {
            expect(builder._stringArray instanceof Array).to.equal(true, 'Data must be of type array');
            compareArray(builder._stringArray, Array.from(string));
        });

        it('appends correctly', function () {
            let temp = ', world';
            builder.append(temp);
            compareArray(builder._stringArray, Array.from(string + temp));
        });

        it('prepends correctly', function () {
            let str = 'test ';
            builder.prepend(str);
            compareArray(builder._stringArray, Array.from(str + string));
        });

        it('inserts correctly', function () {
            let temp = '101';
            builder.insertAt(temp, 3);
            let expected = Array.from(string);
            expected.splice(3, 0, ...temp);
            compareArray(builder._stringArray, expected);
        });

        it('removes correctly', function () {
            builder.remove(1, 3);
            compareArray(builder._stringArray, Array.from('ho'));
        });

        it('stringifies correctly', function () {
            expect(builder.toString()).to.equal(string);
        });

        it('invalid append parameter', function () {
            const result = () => builder.append(5);
            expect(result).to.throw();
        });

        it('invalid prepend parameter', function () {
            const result = () => builder.prepend(5);
            expect(result).to.throw();
        });

        it('invalid insertAt parameter', function () {
            const result = () => builder.insertAt(5, 1);
            expect(result).to.throw();
        });
    });

    function compareArray(source, expected) {
        expect(source.length).to.equal(expected.length, "Arrays don't match");
        for (let i = 0; i < source.length; i++) {
            expect(source[i]).to.equal(expected[i], 'Element ' + i + ' mismatch');
        }
    }
});