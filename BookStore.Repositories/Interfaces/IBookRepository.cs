using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repositories.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void EditBook(Book book);
        void EditBook(int id);
        void DeleteBook(int bookID);

        Book GetBookByID(int id);

        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> GetAllBooksWithFullRelationalData();
    }
}
