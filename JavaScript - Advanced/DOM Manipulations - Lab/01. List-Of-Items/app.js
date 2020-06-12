function addItem() {

    const text = document.getElementById('newItemText');
    const items = document.getElementById('items');

    let textValue = text.value;
    let li = document.createElement('li');

    li.appendChild(document.createTextNode(textValue));
    items.appendChild(li);

    text.value = '';
}