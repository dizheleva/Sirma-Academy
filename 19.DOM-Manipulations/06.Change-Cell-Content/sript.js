const tableBodyElement = document.querySelector('#myTable > tbody');

function changeContent(row, column, content) {

    const tableBodyLength = tableBodyElement.children.length;
    const tableRowLength = tableBodyElement.firstChild.children.length;

    if (!isCorrectInput(row, tableBodyLength) || !isCorrectInput(column, tableRowLength)) {

        alert('Please set correct row and column numbers!');

    } else {
        const tableRow = tableBodyElement.children[row - 1];
        const cell = tableRow.children[column - 1];

        cell.innerHTML = content;

        clearInputFields();
    }
}

function isCorrectInput(input, length) {
    if (!input || input <= 0 || input > length) {
        return false;
    }

    return true;
}

function clearInputFields() {
    document.getElementById('row').value = '';
    document.getElementById('column').value = '';
    document.getElementById('content').value = '';
}