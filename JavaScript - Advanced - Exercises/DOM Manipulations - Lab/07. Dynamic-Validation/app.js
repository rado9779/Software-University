function validate() {
    let regex = /^([\w\-.]+)@([a-z]+)(\.[a-z]+)+$/;

    const inputEmail = document.getElementById('email');
    inputEmail.addEventListener('change', checkEmail);

    function checkEmail(event) {

        if (regex.test(event.target.value)) {
            event.target.removeAttribute('class');
            return;
        }

        event.target.className = 'error';
    }
}