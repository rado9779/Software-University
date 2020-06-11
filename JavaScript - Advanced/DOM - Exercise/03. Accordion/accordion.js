function toggle() {

    const div = document.querySelector('#extra');
    const button = document.getElementsByClassName('button')[0];

    if (div.style.display === 'block') {
        div.style.display = 'none';
        button.textContent = 'More';
    }
    else {
        div.style.display = 'block';
        button.textContent = 'Less';
    }
}