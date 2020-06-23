function attachGradientEvents() {
    const gradient = document.getElementById('gradient');
    const result = document.getElementById('result');

    gradient.addEventListener('mousemove', insideGradient);
    gradient.addEventListener('mouseout', outsideGradient);

    function insideGradient(event) {
        let positionValue = event.offsetX / (event.target.clientWidth - 1);
        positionValue = Math.trunc(positionValue * 100);
        result.textContent = `${positionValue}%`;
    }

    function outsideGradient() {
        result.textContent = "";
    }
}