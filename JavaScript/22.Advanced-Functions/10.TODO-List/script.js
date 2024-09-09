document.getElementById('add-button').addEventListener('click', addTask);

function addTask() {
    const input = document.getElementById('todo-input');
    const task = input.value.trim();

    if (task.length > 0) {
        const li = createTask(task);
        const list = document.getElementById('todo-list');
        list.appendChild(li);
        input.value = '';
    } else {
        alert('Please enter valid task!');
    }
}

function createTask(value) {
    const li = document.createElement('li');
    li.textContent = value;
    const removeBtn = createRemoveButton();
    li.appendChild(removeBtn);
    return li;
}

function createRemoveButton() {
    const button = document.createElement('button');
    button.className = 'remove-button';
    button.addEventListener('click', removeTask);
    return button;
}

function removeTask(event) {
    const task = event.target.parentNode;
    task.parentNode.removeChild(task);
    alert('Task successfully deleted!');
}