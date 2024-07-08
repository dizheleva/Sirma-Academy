const table = document.getElementById('myTable');

function createTable(rows, columns) {

    resetTable();

    const tableBodyElement = document.createElement('tbody');

    for (let row = 1; row <= rows; row++) {
        const rowElement = document.createElement('tr');

        for (let col = 1; col <= columns; col++) {
            const cell = document.createElement('td');
            cell.textContent = `Row-${row} Column-${col}`;

            rowElement.appendChild(cell);
        }

        tableBodyElement.appendChild(rowElement);
    }

    table.appendChild(tableBodyElement);

    clearInputFields();
}

function resetTable() {
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
}

function clearInputFields() {
    document.getElementById('rows').value = '';
    document.getElementById('columns').value = '';
}