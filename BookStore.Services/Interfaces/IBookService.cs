using BookStore.Entities;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;
using BookStore.Entities.Quotes;

namespace BookStore.Services.Interfaces
{
    public interface IBookService
    {
        void Add(Book book);
        void Edit(Book book);

        void Edit(int id);
        void Delete(int bookID);

        Book GetBookByID(int id);

        IEnumerable<Book> GetAllBooks();

        Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns(
            IEnumerable<Category> categories,
            IEnumerable<Author> authors,
            IEnumerable<Publisher> publishers);

        IEnumerable<Book> GetAllBooksWithFullRelationalData();
        void Add(QuoteMap quote);

    }
}
