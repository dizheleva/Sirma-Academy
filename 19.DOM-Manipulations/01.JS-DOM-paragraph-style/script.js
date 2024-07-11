function restyle() {
    const families = ['Times New Roman', 'Georgia', 'Garamond', 'Arial', 'Verdana', 'Helvetica', 'Courier New', 'Lucida Console', 'Monaco', 'Brush Script MT', 'Lucida Handwriting', 'Copperplate', 'Papyrus'];

    const pElement = document.getElementById('text');    

    pElement.style.color = '#' + Math.floor(Math.random() * 16777215).toString(16);
    pElement.style.fontFamily = families[Math.floor(Math.random() * families.length)];
    pElement.style.fontSize = Math.floor((Math.random() * 32) + 10) + 'px';
}