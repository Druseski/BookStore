using BookStore.Data;
using BookStore.Entities;
using BookStore.Entities.Loger;
using BookStore.Entities.Quotes;
using BookStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Repositories
{

    public class BookRepository : IBookRepository
    {

        private readonly DataContext _context;
        private readonly ILogger<BookRepository> _logger;


        public BookRepository(DataContext context, ILogger<BookRepository> logger)
        {
            _logger = logger;
            _context = context;
        }

        public void AddBook(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                _logger.LogInformation(LoggerMessageDisplay.BookCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.BookNotCreatedModelStateInvalid + "|" + ex);
                throw;
            }



        }

        public void AddQuote(QuoteMap quote)
        {
            try
            {
                _context.Quotes.Add(quote);
                _context.SaveChanges();
                _logger.LogInformation("Quote Addet to DB");
            }
            catch (Exception ex)
            {
                _logger.LogError("Quote NOT Added to DB |" + ex);
                throw;
            }
        }


        public void DeleteBook(int bookID)
        {

            Book book = GetBookByID(bookID);
            _context.Books.Remove(book);
            _context.SaveChanges();

        }

        public void EditBook(Book book)
        {

            _context.Books.Update(book);
            _context.SaveChanges();


        }

        public void EditBook(int id)
        {

            var book = GetBookByID(id);
            _context.Books.Update(book);
            _context.SaveChanges();



        }

        public IEnumerable<Book> GetAllBooks()
        {
            //var result = _context.Books.FromSqlRaw("SELECT * FROM Books").AsEnumerable();
            var result = _context.Books.AsEnumerable();
            return result;
        }

        public IEnumerable<Book> GetAllBooksWithFullRelationalData()
        {
            var result = _context.Books
                .Include(a => a.Author)
                .Include(c => c.Category)
                .Include(p => p.Publisher)
                .AsEnumerable();
            return result;

        }
        public Book GetBookByID(int id)
        {
            //var result = _context.Books.FromSqlRaw("SELECT * FROM Books WHERE ID=" + id).FirstOrDefault();
            var result = _context.Books.FirstOrDefault(x => x.ID == id);
            return result;
        }
    }
}
