function isNumberAmazing(num) {

    let number = num.toString();
    let sum = 0;

    for (let i = 0; i < number.length; i++) {
        sum += Number(number[i]);
    }

    let result = sum.toString().includes(9);

    console.log(result ? `${num} Amazing? True` : `${num} Amazing? False`);
}