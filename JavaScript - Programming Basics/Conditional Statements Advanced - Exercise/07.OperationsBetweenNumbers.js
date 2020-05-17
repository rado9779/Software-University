function calculator(n1, n2, sign) {

    let num1 = Number(n1);
    let num2 = Number(n2);

    let oddOrEven;
    let result = 0;

    if (sign == '+') {
        result = num1 + num2;

        if (result % 2 == 0) {
            oddOrEven = "even";
        }
        else {
            oddOrEven = "odd";
        }
        console.log(`${num1} + ${num2} = ${result} - ${oddOrEven}`);
    }
    else if (sign == '-') {
        result = num1 - num2;

        if (result % 2 == 0) {
            oddOrEven = "even";
        }
        else {
            oddOrEven = "odd";
        }
        console.log(`${num1} - ${num2} = ${result} - ${oddOrEven}`);
    }
    else if (sign == '*') {
        result = num1 * num2;

        if (result % 2 == 0) {
            oddOrEven = "even";
        }
        else {
            oddOrEven = "odd";
        }
        console.log(`${num1} * ${num2} = ${result} - ${oddOrEven}`);
    }
    else if (sign == '/') {
        if (num2 == 0) {
            console.log(`Cannot divide ${num1} by zero`);
        }
        else {
            result = num1 / num2;
            console.log(`${num1} / ${num2} = ${result.toFixed(2)}`);
        }
    }
    else if (sign == '%') {
        if (num2 == 0) {
            console.log(`Cannot divide ${num1} by zero`);
        }
        else {
            result = num1 % num2;
            console.log(`${num1} % ${num2} = ${result}`);
        }
    }
}

