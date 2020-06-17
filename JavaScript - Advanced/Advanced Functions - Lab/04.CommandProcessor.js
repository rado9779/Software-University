function solution() {

    let result = '';

    return {
        append: (string) => result += string,
        removeStart: (number) => result = result.substring(number),
        removeEnd: (number) => result = result.substring(0, result.length - number),
        print: () => console.log(result)
    }
}