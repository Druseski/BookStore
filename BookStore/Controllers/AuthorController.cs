using BookStore.Entities;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            var allAuthors = _authorService.GetAllAuthors();
            return View(allAuthors);
        }

        [HttpPost]
        public JsonResult CreateAuthorAJAX(Author author)
        {
            if (author != null)
            {
                if (!string.IsNullOrEmpty(author.Name))
                {
                    _authorService.Add(author);
                    return Json(new { data = author });
                }
                else
                {
                    return Json(new { data = "" });
                }
            }
            else
            {
                return Json(new { data = "" });
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {

            if (author != null)
            {
                if (!string.IsNullOrEmpty(author.Name) || !string.IsNullOrWhiteSpace(author.Name))
                {
                    _authorService.Add(author);

                }

            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = _authorService.GetAuthorById(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _authorService.Edit(author);
            return RedirectToAction(nameof(Index));


        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var author = _authorService.GetAuthorById(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Delete(Author author)
        {
            _authorService.Delete(author.ID);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var author = _authorService.GetAuthorById(id);
            return View(author);

        }
    }
}
