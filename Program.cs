using System;
using System.Collections.Generic;
// created books
Book book1 = new Book()
{
    Author = "Andrew Ward",
    Title = "20,000 Leagues Under the Sea",
    PublishDate = new DateTime(2022, 8, 24),
    NumberOfPages = 200
};

Book book2 = new Book()
{
    Author = "Ben Shelton",
    Title = "The Ember in the Marsh",
    PublishDate = new DateTime(2022, 7, 19),
    NumberOfPages = 168
};

Book book3 = new Book()
{
    Author = "Seth Lewis",
    Title = "Tower and the Wolf",
    PublishDate = new DateTime(2022, 8, 12),
    NumberOfPages = 215
};

//list of books
List<Book> bookList = new List<Book>();

// add each book to bookList (similar to array.push() from JS)
bookList.Add(book1);
bookList.Add(book2);
bookList.Add(book3);

foreach (Book book in bookList)
{
    Console.WriteLine($"{book.Title} by {book.Author}");
}
// Book class
public class Book
{
    public Book() { }
    public Book(string author, string title, DateTime publishDate, int pages)
    {
        Title = title;
        Author = author;
        PublishDate = publishDate;
        NumberOfPages = pages;
    }
    public string Author { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int NumberOfPages { get; set; }
}