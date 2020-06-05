function JSONtoHTML(input) {

    let result = "";
    result += "<table>\n";
    result += "  <tr><th>name</th><th>score</th></tr>\n";

    let people = JSON.parse(input);

    for (const person of people) {
        result += `  <tr><td>${htmlEscape(person.name)}</td><td>${person.score}</td></tr>\n`;
    }

    result += "</table>";
    return result;

    function htmlEscape(key) {
        let replaced = key.toString();
        replaced = replaced.split('&').join('&amp;');
        replaced = replaced.split('<').join('&lt;');
        replaced = replaced.split('>').join('&gt;');
        replaced = replaced.split('"').join('&quot;');
        replaced = replaced.split('\'').join('&#39;');

        return replaced;
    }
}