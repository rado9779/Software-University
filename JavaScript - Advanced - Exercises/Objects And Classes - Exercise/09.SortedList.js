class List {

    constructor() {
        this.array = [];
        this.size = 0;
    }

    add(element) {
        this.array.push(element);
        this.size++;
        this.array.sort((a, b) => a - b);
        return this.array;
    }

    remove(index) {
        if (index >= 0 && index < this.array.length) {
            this.array.splice(index, 1);
            this.size--;
            this.array.sort((a, b) => a - b);
            return this.array;
        }
    }

    get(index) {
        if (index >= 0 && index < this.array.length) {
            return this.array[index];
        }
    }
}