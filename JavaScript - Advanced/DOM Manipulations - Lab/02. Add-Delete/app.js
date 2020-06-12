function addItem() {

    const items = document.getElementById('items');
    const text = document.getElementById('newText');

    let textValue = text.value;

    if (textValue.length === 0) {
        return;
    }

    let li = document.createElement('li');
    li.textContent = textValue;

    let remove = document.createElement('a');
    let linkText = document.createTextNode('[Delete]');
    remove.appendChild(linkText);
    remove.href = '#';
    remove.addEventListener('click', deleteItem);

    li.appendChild(remove);
    items.appendChild(li);

    text.value = ''

    function deleteItem() {
        li.remove();
    }
}