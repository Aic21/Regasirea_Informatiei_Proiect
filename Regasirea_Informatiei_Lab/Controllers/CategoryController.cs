using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly ICategoryServices categoryService;
        private readonly IProductService productService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        public UserManager<User> UserManager { get; }

        public CategoryController(IWebHostEnvironment _hostingEnvironment, ICategoryServices _categoryServices, IProductService _productService,
            RoleManager<IdentityRole> _roleManager,
               UserManager<User> _userManager)
        {
            hostingEnvironment = _hostingEnvironment;
            categoryService = _categoryServices;
            productService = _productService;
            roleManager = _roleManager;
            userManager = _userManager;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CategoryList()
        {
            var catlist = categoryService.ListAllCategory();
            return View("ListCategory", catlist);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateCategory()
        {
            return View("CreateCategory");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateCategory(CreateCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {

                Category categorie = new Category
                {
                    CategoryName = model.Nume

                };

                await categoryService.AddCategoryAsync(categorie);

                return RedirectToAction("CategoryList", "category");
            }

            return View("CategoryList", model);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var cat = await categoryService.GetCategoryByIdAsync(id);

            await categoryService.DeleteCategoryAsync(cat);

            return RedirectToAction("CategoryList", "category");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCategory(int id)
        {
            var category = await categoryService.GetCategoryByIdAsync(id);

            if (category == null)
            {
                ViewBag.ErrorMessage = $"Category with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditCategoryViewModel
            {
                Id = category.CategoryId,
                
                Nume = category.CategoryName
            };

            return View("EditCategory", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCategory(EditCategoryViewModel model)
        {
            var category = await categoryService.GetCategoryByIdAsync(model.Id);

            if (category == null)
            {
                ViewBag.ErrorMessage = $"Category with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                //category.Nume = model.Nume;

                await categoryService.UpdateCategoryAsync(category);

                return RedirectToAction("CategoryList", "category");

            }
            return View("ListCategory", model);
        }

    }
}
