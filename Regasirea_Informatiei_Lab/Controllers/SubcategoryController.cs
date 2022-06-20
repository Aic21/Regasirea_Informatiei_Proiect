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
    public class SubcategoryController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly ISubcategoryServices subcategoryService;
        private readonly ICategoryServices categoryService;
        private readonly IProductService productService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        public UserManager<User> UserManager { get; }

        public SubcategoryController(IWebHostEnvironment _hostingEnvironment, ICategoryServices _categoryService, ISubcategoryServices _subcategoryService, IProductService _productService,
            RoleManager<IdentityRole> _roleManager,
               UserManager<User> _userManager)
        {
            hostingEnvironment = _hostingEnvironment;
            subcategoryService = _subcategoryService;
            productService = _productService;
            roleManager = _roleManager;
            userManager = _userManager;
            categoryService = _categoryService;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult SubCategoryList()
        {
            var sublist = subcategoryService.ListAllSubCategory();
            return View("ListSubcategory", sublist);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateSubcategory()
        {
            CreateSubcategoryViewModel model = new CreateSubcategoryViewModel { };
            foreach (Category cat in categoryService.ListAllCategory())
            {
                model.Categories.Add(cat.CategoryName);
            }

            return View("CreateSubcategory", model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateSubcategory(CreateSubcategoryViewModel model)
        {
            var cat = categoryService.GetCategoryByName(model.Category);
            if (ModelState.IsValid)
            {
                string uniquePhotoFileName = null;
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo.CopyTo(fs);
                    }
                }
                Subcategorie subcategorie = new Subcategorie
                {
                    Nume = model.Nume,
                    Categories = cat[0]


                };

                await subcategoryService.AddSubCategoryAsync(subcategorie);

                return RedirectToAction("SubCategoryList", "subcategory");
            }

            return View("ListSubcategory", model);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteSubCategory(int id)
        {
            var subcat = await subcategoryService.GetSubCategoryByIdAsync(id);

            await subcategoryService.DeleteSubCategoryAsync(subcat);

            return RedirectToAction("SubCategoryList", "subcategory");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditSubCategory(int id)
        {
            var subcategory = await subcategoryService.GetSubCategoryByIdAsync(id);

            if (subcategory == null)
            {
                ViewBag.ErrorMessage = $"Category with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditSubcategoryViewModel
            {
                Id = subcategory.SubCategorieID
                ,
                Nume = subcategory.Nume
            };

            return View("EditSubCategory", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditSubCategory(EditSubcategoryViewModel model)
        {
            var subcategory = await subcategoryService.GetSubCategoryByIdAsync(model.Id);

            if (subcategory == null)
            {
                ViewBag.ErrorMessage = $"Category with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                subcategory.Nume = model.Nume;

                await subcategoryService.UpdateSubCategoryAsync(subcategory);

                return RedirectToAction("EditSubCategory", "subcategory");

            }
            return View("ListSubcategory", model);
        }

    }
}
