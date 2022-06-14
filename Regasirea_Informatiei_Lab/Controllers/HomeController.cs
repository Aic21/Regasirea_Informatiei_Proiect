using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class HomeController : Controller
    {
        private const double V = 0.2;
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryServices _categoryRepository;
        private readonly IProductService _productService;

        private readonly DBContext _dbContext;
        public HomeController(ILogger<HomeController> logger,ICategoryServices categoryServices,DBContext dBContext, IProductService productService)
        {
            _categoryRepository = categoryServices; 
            _logger = logger;
            _dbContext = dBContext;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var categories = _categoryRepository.ListAllCategory().OrderBy(c => c.CategoryName);
            return View(categories);
        }
        public IActionResult Acasa()
        {
            var categories = _categoryRepository.ListAllCategory().OrderBy(c => c.CategoryName);
            return View(categories);
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
