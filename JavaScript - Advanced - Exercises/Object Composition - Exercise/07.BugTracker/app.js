function solution() {

    let object = (() => {

        let result = [];
        let tracker = undefined;
        let count = 0;

        let report = function (author, description, reproducible, severity) {

            result[count] = {
                ID: count,
                author: author,
                description: description,
                reproducible: reproducible,
                severity: severity,
                status: 'Open'
            };
            count++;

            if (tracker) {
                print();
            }
        };

        let setStatus = function (id, newStatus) {
            result[id].status = newStatus;

            if (tracker) {
                print();
            }
        };

        let remove = function (id) {
            result = result.filter(x => x.ID != id);

            if (tracker) {
                print();
            }
        };

        let sort = function (method) {

            switch (method) {
                case 'author':
                    result = result.sort((a, b) => a.author.localeCompare(b.author));
                    break;
                case 'severity':
                    result = result.sort((a, b) => a.severity - b.severity);
                    break;
                case 'ID':
                    result = result.sort((a, b) => a.ID - b.ID);
            }

            if (tracker) {
                print();
            }
        };

        let output = function (selector) {
            tracker = selector;
        };

        let print = function () {
            $(tracker).html("");
            for (let bug of result) {
                $(tracker).append($('<div>').attr('id', "report_" + bug.ID).addClass('report').append($('<div>').addClass('body').append($('<p>').text(bug.description))).append($('<div>').addClass('title').append($('<span>').addClass('author').text('Submitted by: ' + bug.author)).append($('<span>').addClass('status').text(bug.status + " | " + bug.severity))));
            }
        };

        return { report, setStatus, remove, sort, output };
    })();

    return object;
}