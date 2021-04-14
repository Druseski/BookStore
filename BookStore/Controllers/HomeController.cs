using BookStore.Entities.Quotes;
using BookStore.Models;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
            
            _bookService = bookService;

        }

        public IActionResult Index()
        {
            
            var books = _bookService.GetAllBooks();
            var booksWithFullData = _bookService.GetAllBooksWithFullRelationalData();
            var homeViewModel = new HomeviewModel()
            {
                AllBooksList = books
            };

            return View(homeViewModel);
        }

        public async Task<JsonResult> GetQuotes()
        {
            QuotesData quotesData = new QuotesData();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://opinionated-quotes-api.gigalixirapp.com/v1/quotes")) 
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    quotesData = JsonConvert.DeserializeObject<QuotesData>(apiResponse);
                }
            }
            //TODO: Save to our DB

                return Json(quotesData);
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
