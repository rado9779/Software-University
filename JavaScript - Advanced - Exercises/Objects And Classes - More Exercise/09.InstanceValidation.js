class CheckingAccount {

    constructor(clientId, email, firstName, lastName) {
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
        this.products = [];
    }

    get clientId() {
        return this._clientId;
    }
    set clientId(inputClientId) {

        if (typeof inputClientId !== "string") {
            throw new TypeError("Client ID must be a 6-digit number");
        }

        let clientIdValidation = /^\d{6}$/;

        if (!clientIdValidation.test(inputClientId)) {
            throw new TypeError("Client ID must be a 6-digit number");
        }

        this._clientId = inputClientId;
    }

    get email() {
        return this._email;
    }
    set email(inputEmail) {

        let emailValidation = /^\w+@[a-zA-Z.]+$/;

        if (!emailValidation.test(inputEmail)) {
            throw new TypeError("Invalid e-mail");
        }

        this._email = inputEmail;
    }

    get firstName() {
        return this._firstName;
    }
    set firstName(inputFirstName) {

        if (inputFirstName.length < 3 || inputFirstName.length > 20) {
            throw new TypeError("First name must be between 3 and 20 characters long");
        }

        let firstNameValidation = /^[A-Za-z]+$/;

        if (!firstNameValidation.test(inputFirstName)) {
            throw new TypeError("First name must contain only Latin characters");
        }

        this._firstName = inputFirstName;
    }

    get lastName() {
        return this._lastName;
    }
    set lastName(inputLastName) {

        if (inputLastName.length < 3 || inputLastName.length > 20) {
            throw new TypeError("Last name must be between 3 and 20 characters long");
        }

        let lastNameValidation = /^[A-Za-z]+$/;

        if (!lastNameValidation.test(inputLastName)) {
            throw new TypeError("Last name must contain only Latin characters");
        }

        this._lastName = inputLastName;
    }
}