package com.example.libraryapi.controller;

import com.example.libraryapi.model.Book;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/books")
public class BookController {
    private List<Book> books = new ArrayList<>();

    private int currentIndex = 4;

    public BookController() {
        books.add(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        books.add(new Book(2, "To Kill a Mockingbird", "Harper Lee"));
        books.add(new Book(3, "1984", "George Orwell"));
    }

    @GetMapping
    public List<Book> getBooks() {
        return books;
    }

    @PostMapping
    public Book addBook(@RequestBody Book book) {
        if (book.getAuthor() == null || book.getTitle() == null) {
            return null;
        }

        if (books.contains(book)) {
            return null;
        }

        book.setId(currentIndex++);
        books.add(book);
        return book;
    }
}
