using BookManagement.Models;
using BookManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService bookService;
        private readonly ICategoryService categoryService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService , ICategoryService categoryService)
        {
            _logger = logger;
            this.bookService = bookService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Book()
        {
            var books = bookService.GetAllBook();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = categoryService.GetCategories();
            return View();
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
