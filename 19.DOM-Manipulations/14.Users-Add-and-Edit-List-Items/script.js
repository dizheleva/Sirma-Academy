const button = document.getElementsByTagName('button')[0];
button.addEventListener('click', addListItem);

function addListItem() {
    const input = document.getElementsByTagName('input')[0];
    
    if (input.value.length > 0) {
        const li = createListItem(input.value);
        const list = document.getElementById('items');
        list.appendChild(li);
        input.value = '';
    } else {
        alert('Please enter list item value!');
    }
}

function createListItem(value) {
    const li = document.createElement('li');
    li.textContent = value;
    li.addEventListener('click', createInput);
    return li;
}

function editListItem(event) {
    if (event.target.value.length > 0) {
        const newLi = createListItem(event.target.value);
        event.target.parentNode.replaceWith(newLi);
    } else {
        event.target.parentNode.parentNode.removeChild(event.target.parentNode);
        alert('Successfully deleted list item!');
    }
}

function createInput(event) {
    if (document.getElementById('inputLi')) {
        return;
    }
    
    const currentLi = event.target;

    const inputLi = document.createElement('input');
    inputLi.id = 'inputLi';
    inputLi.value = currentLi.textContent;

    currentLi.textContent = '';
    currentLi.appendChild(inputLi);
    inputLi.focus();

    const eventElements = document.querySelectorAll('input, button');    
    for (const element of eventElements) {
        if (element !== inputLi) {
            element.disabled = 'true';
        }
    }

    inputLi.addEventListener('click', editListItem);
    inputLi.addEventListener('keyup', (event) => {
        if (event.key === 'Enter') {
            editListItem();
        }
    });
}