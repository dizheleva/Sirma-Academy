function restyle() {
    const paragraph = document.getElementById('text');

    paragraph.style.backgroundColor = '#' + Math.floor(Math.random() * 16777215).toString(16);
}