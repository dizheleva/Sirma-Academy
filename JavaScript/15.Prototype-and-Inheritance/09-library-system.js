class LibraryItem {
    constructor(title, author) {
        this.title = title;
        this.author = author;
    }

    displayDetails() {
        console.log(`Title: ${this.title}`);
        console.log(`Author: ${this.author}`);
    }
}

class Book extends LibraryItem {
    constructor(title, author, genre) {
        super(title, author);
        this.genre = genre;
    }

    displayDetails() {
        super.displayDetails();
        console.log(`Genre: ${this.genre}`);
    }
}

class Magazine extends LibraryItem {
    constructor(title, author, month, year) {
        super(title, author);
        this.month = month;
        this.year = year;
    }

    displayDetails() {
        super.displayDetails();
        console.log(`Published: ${this.month} / ${this.year}`);
    }
}

const book = new Book('The Dragon Reborn', 'Robert Jordan', 'Fantasy');
book.displayDetails();
const magazine = new Magazine('Discover', 'Kalmbach Media', 'June', 2020);
magazine.displayDetails();