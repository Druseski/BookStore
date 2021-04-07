using BookStore.Data;
using BookStore.Entities;
using BookStore.Entities.Loger;
using BookStore.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
       
        private readonly DataContext _context;

        public AuthorRepository(DataContext context)
        {
            _context = context;
       
        }

        public void AddAuthor(Author author)
        {
        
                _context.Authors.Add(author);
                _context.SaveChanges();
    
        }

        public void DeleteAuthor(int authorId)
        {

       
                Author author = GetAuthorById(authorId);
                _context.Authors.Remove(author);
                _context.SaveChanges();

        }

        public void EditAuthor(Author author)
        {
           
                _context.Authors.Update(author);
                _context.SaveChanges();
  

        }

        public IEnumerable<Author> GetAllAuthors()
        {
            var result = _context.Authors.AsEnumerable();
            return result;
        }

        public Author GetAuthorById(int id)
        {
            var result = _context.Authors.FirstOrDefault(x => x.ID == id);
            return result;
        }
    }
}
