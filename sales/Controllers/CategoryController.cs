using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sales.Models;

namespace sales.Controllers
{
    public class CategoryController : Controller
    {
        //private IWebHostEnvironment _hostEnvironment;
        private ICategory _categoryRepository;

        public CategoryController(
            //IWebHostEnvironment hostingEnvironment;
            ICategory categoryRepository)
        {
            //_hostingEnvironment = hostingEnvironment;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
