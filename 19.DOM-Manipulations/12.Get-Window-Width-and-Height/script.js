function getWindowSize() {
    const width = document.documentElement.clientWidth;
    const height = document.documentElement.clientHeight;

    const widthInput = document.getElementById('width');
    widthInput.value = `${width}px`;

    const heightInput = document.getElementById('height');
    heightInput.value = `${height}px`;
}