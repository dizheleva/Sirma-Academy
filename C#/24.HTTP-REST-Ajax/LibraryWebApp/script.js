const apiUrl = 'http://localhost:8080/books';

async function getBooks() {
    const response = await fetch(apiUrl);
    const books = await response.json();
    const booksList = document.getElementById('bookList');
    booksList.innerHTML = '';
    books.forEach(book => {
        const li = document.createElement('li');
        li.innerHTML = `<strong>${book.title}</strong> by ${book.author}`;
        booksList.appendChild(li);
    });
}

async function addBook(book) {
    const response = await fetch(apiUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(book),
    });

    if (response.ok) {
        getBooks();
        document.getElementById('addBookForm').reset();
    }
}

const addBookForm = document.getElementById('addBookForm');
addBookForm.addEventListener('submit', event => {
    event.preventDefault();

    const title = document.getElementById('title').value;
    const author = document.getElementById('author').value;
    const book = { title, author };
    addBook(book);
});

getBooks();