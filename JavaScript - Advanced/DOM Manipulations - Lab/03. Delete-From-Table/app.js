function deleteByEmail() {

    const result = document.getElementById('result');
    const inputEmail = document.getElementsByName('email')[0];
    const emailTds = document.querySelectorAll('td');

    let isDeleted = false;

    for (const td of emailTds) {

        if (td.textContent === inputEmail.value) {
            td.parentNode.parentNode.removeChild(td.parentNode);
            isDeleted = true;
        }
    }

    if (isDeleted) {
        result.textContent = 'Deleted';
    }
    else {
        result.textContent = 'Not found.';
    }
}