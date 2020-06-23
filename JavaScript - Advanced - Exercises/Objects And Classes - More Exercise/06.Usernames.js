function uniqueUsernames(input) {

    let result = new Set(input
        .sort((a, b) => a.localeCompare(b))
        .sort((a, b) => a.length - b.length));

    for (const username of result) {
        console.log(username);
    }
}