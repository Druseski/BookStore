using BookStore.Entities;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        public IActionResult Index()
        {
            var allPublishers = _publisherService.GetAllPublishers();
            return View(allPublishers);
        }

        [HttpPost]
        public JsonResult CreatePublisherAJAX(Publisher publisher)
        {
            if (publisher != null)
            {
                if (!string.IsNullOrEmpty(publisher.Name))
                {
                    _publisherService.Add(publisher);
                    return Json(new { data = publisher});
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
        public IActionResult Create(Publisher publisher)
        {
            _publisherService.Add(publisher);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(publisher);
        }
        [HttpPost]
        public IActionResult Edit(Publisher publisher)
        {
            _publisherService.Edit(publisher);
            return RedirectToAction(nameof(Index));


        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(publisher);
        }
        [HttpPost]
        public IActionResult Delete(Publisher publisher)
        {
            _publisherService.Delete(publisher.ID);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(publisher);

        }
    }
}
