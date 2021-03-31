﻿using BookStore.Entities;
using BookStore.Models;
using BookStore.Services;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;

        public BookController(
            IBookService bookService,
            IAuthorService authorService,
            ICategoryService categoryService,
            IPublisherService publisherService
            )
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
            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();
            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);

            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorID = dropdowns.Item2;
            ViewBag.PublisherID = dropdowns.Item3;
            //ViewBag.CategoryList = categories;
            //ViewBag.AuthorID = authors;
            //ViewBag.PublisherID = publishers;
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var book = new Book()
                //{
                //   AuthorID = model.AuthorID,
                //   AuthorName = model.AuthorName,
                //};

                //var author = new Author();
                //author.Name = model.AuthorNameDTO;
                //author.Country = model.AuthorCountryDTO;
                //author.DateBirth = model.AuthorDateBirthDTO;
                //author.Gender = model.AuthorGenderDTO;
                //author.Language = model.AuthorLanguageDTO;
                //author.Popularity = model.AuthorPopularityDTO;
                //author.ShortDiscription = model.AuthorShortDiscriptionDTO;
                //_authorService.Add(author);
                //... category, publisher...

                var book = new Book();
                book.Title = model.Title;
                book.AuthorID = model.AuthorID;
                book.AuthorName = model.AuthorNameDTO;
                book.BookCoverType = model.BookCoverType;
                book.BookType = model.BookType;
                book.Category = model.Category;
                book.CategoryID = model.CategoryID;
                book.CategoryName = model.CategoryName;
                book.Copies = model.Copies;
                book.Country = model.Country;
                book.DateAdded = DateTime.Now;
                book.Dimension = model.Dimension;
                book.Discription = model.Discription;
                book.Edition = model.Edition;
                book.Genre = model.Genre;
                book.Language = model.Language;
                book.NumberOfPages = model.NumberOfPages;
                book.PhotoURL = model.PhotoURL;
                book.Price = model.Price;
                book.PublisherName = model.PublisherName;
                book.PublisherID = model.PublisherID;
                book.Rating = model.Rating;
                book.Shipping = model.Shipping;
                book.SoldItems = model.SoldItems;
                book.Weight = model.Weight;
                book.YearOfIssue = model.YearOfIssue;


                _bookService.Add(book);


            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBookByID(id);
            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();
            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);


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
            var book = _bookService.GetBookByID(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookByID(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _bookService.GetBookByID(id);
            _bookService.Delete(book.ID);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public JsonResult GetAllBooksAJAX()
        {
            var allBooks = _bookService.GetAllBooks();
            return Json(new { booksData = allBooks });
        }
    }



}
