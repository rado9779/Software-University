(function stringExtension() {

    String.prototype.ensureStart = function (str) {

        if (this.startsWith(str) === false) {
            return `${str}${this}`;
        }

        return this.toString();
    };

    String.prototype.ensureEnd = function (str) {

        if (this.endsWith(str) === false) {
            return `${this}${str}`;
        }

        return this.toString();
    };

    String.prototype.isEmpty = function () {
        return this.toString().length === 0;
    };

    String.prototype.truncate = function (n) {

        if (n < 4) {
            return ".".repeat(n);
        }
        if (this.toString().length <= n) {
            return this.toString();
        }
        else {
            let lastIndex = this.toString().substr(0, n - 2).lastIndexOf(" ");

            if (lastIndex != -1) {
                return `${this.toString().substr(0, lastIndex)}...`;
            }
            else {
                return `${this.toString().substr(0, n - 3)}...`
            }
        }
    };

    String.format = function (string, ...params) {
        for (let i = 0; i < params.length; i++) {
            string = string.replace(`{${i}}`, params[i]);
        }

        return string;
    };
})();