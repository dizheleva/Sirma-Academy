function insertRow() {
    const tableBodyElement = document.querySelector('#sampleTable > tbody');
    const rowCount = tableBodyElement.children.length;
    const rowLength = tableBodyElement.firstChild.children.length;

    const rowElement = document.createElement('tr');

    for (let cellNumber = 1; cellNumber <= rowLength; cellNumber++) {
        const cell = document.createElement('td');
        cell.textContent = `Row${rowCount + 1} cell${cellNumber}`;

        rowElement.appendChild(cell);
    }

    tableBodyElement.appendChild(rowElement);
}