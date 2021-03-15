using BookStore.Entities;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;

        public BookController(IBookService bookService,
            IAuthorService authorService,
            ICategoryService categoryService,
            IPublisherService publisherService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _categoryService = categoryService;
            _publisherService = publisherService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var dropdowns = _bookService.FillDropdowns();

            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();
           
            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorID = dropdowns.Item2;
            ViewBag.PublisherID = dropdowns.Item3;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBookByID(id);
            var dropdowns = _bookService.FillDropdowns();

            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorID = dropdowns.Item2;
            ViewBag.PublisherID = dropdowns.Item3;

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Edit(book);
            }
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int bookID)
        {

            return View();
        }
    }
}
