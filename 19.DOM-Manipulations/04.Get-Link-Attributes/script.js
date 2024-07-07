function getAttributes() {
    const link = document.getElementsByTagName('a')[0];
    const attributes = Array.from(link.attributes);

    let text = '';

    attributes.forEach(attribute => {
        console.log(`${attribute.name}=${attribute.value}`);
        text += attribute.name + "=" + attribute.value + "<br>";
    })

    document.getElementById('demo').innerHTML = text;
}