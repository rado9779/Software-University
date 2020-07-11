const expect = require('chai').expect;
const Console = require('../06.C#Console').Console;

describe("Console", function () {

    it("should return string input correct", function () {
        let input = "string";
        expect(Console.writeLine(input)).to.equal(input);
    });

    it("should return JSON string input", function () {
        let input = { Key: "Test", Value: "1" };
        expect(Console.writeLine(input)).to.equal(JSON.stringify(input))
    });

    it("should throw error with empty input", function () {
        expect(() => Console.writeLine()).to.throw(TypeError);
    });

    it("should throw error with not number as first parameter", function () {
        expect(() => Console.writeLine(5, 1, 2)).to.throw(TypeError)
    });

    it("should throw error if placeholders are less than parameters", function () {
        let input = "This {0} should {1} replaced.";
        expect(() => Console.writeLine(input, "one", "be", "three")).to.throw(RangeError);
    });

    it("should throw error placeholders are changed", function () {
        let input = "This {0} should {0} replaced.";
        expect(() => Console.writeLine(input, "one", "be")).to.throw(RangeError);
    });

    it("should return result with correct input parameters", function () {
        let input = "This {0} should {1} replaced.";
        expect(Console.writeLine(input, "one", "be")).to.equal("This one should be replaced.");
    });

    it("should throw error with invalid placeholder input", function () {
        let input = "This {0} should {1} replaced. This one {2} not work.";
        expect(() => Console.writeLine(input, "one", "be")).to.throw(RangeError);
    });

    it("should return placeholder index", function () {
        expect(() => Console.writeLine("Not {10}", "valid")).to.throw(RangeError);
    });
});