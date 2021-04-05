﻿using BookStore.Models;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;


        public HomeController(
            ILogger<HomeController> logger,
            IBookService bookService)
        {
            _logger = logger;
            logger.LogDebug(1, "NLog injected into HomeController");
            _bookService = bookService;

        }

        public IActionResult Index()
        {
            _logger.LogInformation("Hello, this is the index!");
            var books = _bookService.GetAllBooks();
            var booksWithFullData = _bookService.GetAllBooksWithFullRelationalData();
            var homeViewModel = new HomeviewModel()
            {
                AllBooksList = books
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
