function getOptions() {
    const list = document.getElementById('mySelect');
    const count = list.children.length;
    
    let message = `The list has ${count} options:\n`

    const options = Array.from(list.children);
    options.forEach(option => {
        message += option.value + '\n';
    });

    alert(message);
}