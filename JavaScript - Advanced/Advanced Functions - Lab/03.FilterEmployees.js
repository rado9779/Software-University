function filterEmployees(data, criteria) {

    data = JSON.parse(data);

    criteria = criteria.split('-');
    let criteriaName = criteria[0];
    let criteriaValue = criteria[1];

    data.filter(function (x) {
        return x[criteriaName] === criteriaValue;
    }).forEach((item, i) => {
        console.log(`${i}. ${item.first_name} ${item.last_name} - ${item.email}`);
    });;
}
