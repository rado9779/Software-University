const expect = require('chai').expect;
const PaymentPackage = require('../05.PaymentPackage');

describe('PaymentPackage', () => {

    it('should have a constructor', () => {
        expect(PaymentPackage.prototype).to.haveOwnProperty('constructor');
    });

    it('should throw error with number input as first parameter', () => {
        const result = () => { const p = new PaymentPackage(7, 200); }
        expect(result).to.throw(Error, 'Name must be a non-empty string');
    });

    it('should throw error with empty string input as second parameter', () => {
        const result = () => { const p = new PaymentPackage('', 200); }
        expect(result).to.throw(Error, 'Name must be a non-empty string');
    });

    it('should throw error with empty input as paramater', () => {
        const result = () => { const p = new PaymentPackage('string'); }
        expect(result).to.throw(Error, 'Value must be a non-negative number');
    });

    it('should throw error with string input as parameter', () => {
        const result = () => { const p = new PaymentPackage('input', 'asd'); }
        expect(result).to.throw(Error, 'Value must be a non-negative number');
    });

    it('should throw error with negative number input as parameter', () => {
        const result = () => { const p = new PaymentPackage('string', -1); }
        expect(result).to.throw(Error, 'Value must be a non-negative number');
    });

    it('should throw error with a string type for VAT', () => {
        const result = () => {
            const p = new PaymentPackage('input', 7);
            p.VAT = '7';
        }
        expect(result).to.throw(Error, 'VAT must be a non-negative number');
    });

    it('should throw error with a negative number for VAT', () => {
        const result = () => {
            const p = new PaymentPackage('input', 7);
            p.VAT = -7;
        }
        expect(result).to.throw(Error, 'VAT must be a non-negative number');
    });

    it('should throw error with a boolean for VAT', () => {
        const result = () => {
            const p = new PaymentPackage('input', 7);
            p.VAT = false;
        }
        expect(result).to.throw(Error, 'VAT must be a non-negative number');
    });

    it('should throw error with a number for active', () => {
        const result = () => {
            const p = new PaymentPackage('input', 7);
            p.active = 5;
        }
        expect(result).to.throw(Error, 'Active status must be a boolean');
    });

    it('should throw error when trying to set a string for active', () => {
        const result = () => {
            const p = new PaymentPackage('input', 7);
            p.active = '5';
        }
        expect(result).to.throw(Error, 'Active status must be a boolean');
    });

    it('should return name correctly', () => {
        const p = new PaymentPackage('input', 200);
        expect(p.name).to.be.equal('input');
    });

    it('should return value correctly', () => {
        const p = new PaymentPackage('input', 200);
        expect(p.value).to.be.equal(200);
    });

    it('should return VAT correctly', () => {
        const p = new PaymentPackage('input', 200);
        expect(p.VAT).to.be.equal(20);
    });

    it('should return active correctly', () => {
        const p = new PaymentPackage('input', 200);
        expect(p.active).to.be.equal(true);
    });

    it('should return "toString" method', () => {
        expect(PaymentPackage.prototype).to.haveOwnProperty('toString');
    });

    it('should return "toString" method functionality with "false" active', () => {
        const p = new PaymentPackage('HR Services', 1500);
        p.active = false;
        const result = ['Package: HR Services (inactive)', '- Value (excl. VAT): 1500', '- Value (VAT 20%): 1800'].join('\n');
        expect(p.toString()).to.be.equal(result);
    });

    it('should return "toString" method functionality with "true" active', () => {
        const p = new PaymentPackage('HR Services', 1500);
        const result = ['Package: HR Services', '- Value (excl. VAT): 1500', '- Value (VAT 20%): 1800'].join('\n');
        expect(p.toString()).to.be.equal(result);
    });
});