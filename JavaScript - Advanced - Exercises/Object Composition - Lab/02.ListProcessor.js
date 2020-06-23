function solution(input) {

    let processor = (function () {
        let list = [];

        return {
            add: string => list.push(string),
            remove: string => list = list.filter(x => x !== string),
            print: () => console.log(list.join(','))
        }
    })();

    for (const commands of input) {
        let line = commands.split(' ');

        if (line[0] === 'add') {
            processor.add(line[1]);
        }
        else if (line[0] === 'remove') {
            processor.remove(line[1]);
        }
        else if (line[0] === 'print') {
            processor.print();
        }
    }
}