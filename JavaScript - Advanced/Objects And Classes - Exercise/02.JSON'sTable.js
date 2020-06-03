function JSONtoHTML(input) {

    let result = "<table>\n";

    for (const line of input) {

        let person = JSON.parse(line);

        result += "	<tr>\n";
        result += `		<td>${person.name}</td>\n`;
        result += `		<td>${person.position}</td>\n`;
        result += `		<td>${person.salary}</td>\n`;
        result += "	</tr>\n";
    }

    result += "</table>";
    console.log(result);
}