function bookSeeking(input) {

    let favoriteBook = input.shift();
    let numberOfBooks = Number(input.shift());

    let counter = 0;
    let isFound = false;

    while (counter < numberOfBooks) {
        let nextBook = input.shift();

        if (nextBook == favoriteBook) {
            isFound = true;
            break;
        }
        counter++;
    }

    if (isFound) {
        console.log(`You checked ${counter} books and found it.`);
    }
    else {
        console.log(`The book you search is not here!`);
        console.log(`You checked ${counter} books.`);
    }
}
