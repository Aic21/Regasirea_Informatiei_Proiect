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
using PagedList.Mvc;
using PagedList;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly ICategoryServices categoryService;

        private readonly IProductService productService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        public UserManager<User> UserManager { get; }

        public ProductController(IWebHostEnvironment _hostingEnvironment,   ICategoryServices _categoryServices, IProductService _productService,
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
        [Authorize(Roles = "User")]
        public IActionResult ListProduct()
        {
            var product = productService.ListAllProductWith();
            return View("ListProduct", product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateProduct()
        {
            CreateProductViewModel model = new CreateProductViewModel { };
            foreach (Category cat in categoryService.ListAllCategory())
            {
                model.Categories.Add(cat.CategoryName);
            }

            return View("CreateProduct", model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel model)
        {
            var cat = categoryService.GetCategoryByName(model.Category);

            if (ModelState.IsValid)
            {
                //  var productCategorie = categoryService.GetCategoryByName(model.Nume);

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
                

                Product produs = new Product
                {
                    ProductName = model.Nume,
                    ProductId = model.ProdusId,
                    ProductDescription = model.Descriere,
                    Pret = model.Pret,
                    //Furnizor = model.Furnizor,
                    //Stoc = model.Stoc,
                    //Categories = productCategorie[0],
                    ProductPicture = uniquePhotoFileName,
                    //Picture1 = uniquePhotoFileName1,
                   // Picture2 = uniquePhotoFileName2,
                    //Picture3 = uniquePhotoFileName3,
                    Category = cat[0]
                };

                await productService.AddProductAsync(produs);

                return RedirectToAction("ListProduct", "product");
            }

            return View("CreateProduct", model);
        }
        [AllowAnonymous]

        public ViewResult List(string category,int? page)
        {
            IEnumerable<Product> product;
            string currentSubCategory;

            if (string.IsNullOrEmpty(category))
            {
                product = productService.ListAllProduct();
                currentSubCategory = "All Product";
            }
            else
            {
                product = productService.ListAllProduct().Where(c => c.Category.CategoryName == category);

                currentSubCategory = categoryService.ListAllCategory().FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = product.ToList(),
                CurrentCategory = currentSubCategory
            });
        }

        // [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productService.GetProductByIdAsync(id);

            await productService.DeleteProductAsync(product);

            return RedirectToAction("ListProduct", "product");
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditProduct(int id)
        {
            var product = await productService.GetProductByIdAsync(id);

            if (product == null)
            {
                ViewBag.ErrorMessage = $"Car option with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditProductViewModel
            {
                Id = product.ProductId,
                Nume = product.ProductName,
                Pret = product.Pret,
                Descriere = product.ProductDescription,
                Categories = product.Category
            };

            return View("EditProduct", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditProduct(EditProductViewModel model)
        {
            var product = await productService.GetProductByIdAsync(model.Id);

            if (product == null)
            {
                ViewBag.ErrorMessage = $"Product with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
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
                product.ProductName = model.Nume;
                product.ProductDescription = model.Descriere;
                product.Pret = model.Pret;
                product.ProductPicture = uniquePhotoFileName;

                await productService.UpdateProductAsync(product);

                return RedirectToAction("ListProduct", "product");

            }
            return View("ListProduct", model);
        }



    }
}
