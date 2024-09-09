function calculateVolume(radius) {
    const volume = (Math.PI * radius * radius).toFixed(4);

    document.getElementById('volume').value = volume;
}