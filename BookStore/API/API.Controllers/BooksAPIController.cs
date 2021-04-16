using BookStore.Entities;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.API.Controllers
{
    [Route("api/BooksAPI")]
    [ApiController]
    public class BooksAPIController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksAPIController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("Books")]
        public IEnumerable<Book> GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return books.AsEnumerable();
        }
        
    }
}
