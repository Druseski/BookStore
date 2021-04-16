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
        private readonly IQuoteService _quoteService;



        public HomeController(
            ILogger<HomeController> logger,
            IBookService bookService,
            IQuoteService quoteService)
        {
            _logger = logger;
            _bookService = bookService;
            _quoteService = quoteService;
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

                    foreach (var quote in quotesData.Quotes)
                    {
                        QuoteMap newQuote = new QuoteMap()
                        {
                            Author = quote.Author,
                            Language = quote.Language,
                            Quote = quote.quote,
                            Tags = string.Join(",", quote.Tags.ToArray())


                        };
                        _quoteService.Add(newQuote);

                    }
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
