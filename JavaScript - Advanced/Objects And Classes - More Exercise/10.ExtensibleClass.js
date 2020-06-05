(function () {

    let id = 0;

    return class Extensible {
        constructor() {
            this.id = id++;
        }

        extend(template) {

            for (let object in template) {

                if (typeof template[object] === 'function') {
                    Extensible.prototype[object] = template[object];
                } 
                else {
                    this[object] = template[object];
                }
            }
        }
    }
})()