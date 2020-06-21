function solution() {

    return {
        list: [],
        size: 0,

        add: function (element) {
            this.list.push(element);
            this.size++;
            this.list.sort((a, b) => a - b);
        },

        remove: function (index) {

            if (index < 0 || this.list.length <= index) {
                throw new Error('Invalid index!');
            }

            this.list.splice(index, 1);
            this.size--;
        },
        get: function (index) {

            if (index < 0 || this.list.length <= index) {
                throw new Error('Invalid index!');
            }

            return this.list[index];
        }
    }
}