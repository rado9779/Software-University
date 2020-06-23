function solution() {
    
    let object = {
        extend: function (template) {
            for (let item of Object.keys(template)) {

                if (typeof (template[item]) === "function") {
                    Object.getPrototypeOf(object)[item] = template[item];
                }
                else {
                    object[item] = template[item];
                }
            }
        }
    };

    return object;
}