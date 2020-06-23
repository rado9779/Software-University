function solve() {

    const dropdownButton = document.getElementById('dropdown');
    const dropdownList = document.getElementById('dropdown-ul');
    const box = document.getElementById('box');

    dropdownButton.addEventListener('click', listOptions);
    dropdownList.addEventListener('click', changeColor)

    function listOptions(e) {
        
        if (dropdownList.style.display === 'block') {
            dropdownList.style.display = 'none';
            box.style.color = 'white';
            box.style.backgroundColor = 'black';
        }
        else {
            dropdownList.style.display = 'block';
        }
    }

    function changeColor(e) {
        const color = e.target.innerText;
        box.style.color = 'black';
        box.style.backgroundColor = color;
    }
}