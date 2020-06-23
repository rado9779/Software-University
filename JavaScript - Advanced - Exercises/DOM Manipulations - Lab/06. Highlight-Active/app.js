function focus() {

    const sections = document.getElementsByTagName('input');

    for (const section of sections) {
        section.addEventListener('focus', focusSection);
        section.addEventListener('blur', blurSection);
    }

    function focusSection(event) {
        event.target.parentNode.className = 'focused';
    }

    function blurSection(event) {
        event.target.parentNode.className = '';
    }
}