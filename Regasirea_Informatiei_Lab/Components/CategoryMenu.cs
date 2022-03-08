using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;

namespace Regasirea_Informatiei_Lab.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryServices _categoryRepository;
        public CategoryMenu(ICategoryServices categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.ListAllCategory().OrderBy(c => c.CategoryName);

            return View(categories);
        }
    }
}
