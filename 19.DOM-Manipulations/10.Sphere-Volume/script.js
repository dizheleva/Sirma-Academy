function calculateVolume(radius) {
    const volume = (Math.PI * radius * radius).toFixed(4);
    console.log(volume)

    document.getElementById('volume').value = volume;
}