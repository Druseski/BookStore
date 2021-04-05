using BookStore.Data;
using BookStore.Entities;
using BookStore.Entities.Loger;
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



        public BookRepository(DataContext context)
        {
           
            _context = context;
        }

        public void AddBook(Book book)
        {
          
                _context.Books.Add(book);
                _context.SaveChanges();
       


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
