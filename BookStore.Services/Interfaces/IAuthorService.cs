using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Services.Interfaces
{
    public interface IAuthorService
    {
        void Add(Author author);
        void Edit(Author author);
        void Delete(int authorId);
        Author GetAuthorById(int id);
        IEnumerable<Author> GetAllAuthors();
    }
}
