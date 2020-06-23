function getFibonator() {

    let current = 0;
    let next = 1;

    return (() => {

        let temp = current + next;
        current = next;
        next = temp;

        return current;
    })
}