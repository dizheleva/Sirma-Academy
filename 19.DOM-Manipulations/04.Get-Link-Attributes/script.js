function getAttributes() {
    const link = document.getElementsByTagName('a')[0];
    const attributes = Array.from(link.attributes);

    let message = '';

    attributes.forEach(attribute => {
        console.log(`${attribute.name}=${attribute.value}`);
        message += attribute.name + '=' + attribute.value + '\n';
    })

    alert(message);
}