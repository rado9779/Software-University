function printChessBoard(input) {

    let n = Number(input);
    let result = "";

    result += '<div class="chessboard">\n';

    for (let i = 0; i < n; i++) {

        result += '\t<div>\n';

        for (let j = 0; j < n; j++) {

            if ((i + j) % 2 === 0) {
                result += `\t\t<span class="black"></span>\n`;
            }
            else {
                result += `\t\t<span class="white"></span>\n`;
            }
        }

        result += '\t</div>\n';
    }

    result += '</div>';
    return result;
}
