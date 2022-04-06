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
using X.PagedList;
using X.PagedList.Mvc.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly ICategoryServices categoryService;
        private readonly ISubcategoryServices subcategoryService;
        private readonly IProductService productService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        private readonly DBContext context;
        public UserManager<User> UserManager { get; }

        public ProductController(IWebHostEnvironment _hostingEnvironment,   ICategoryServices _categoryServices, IProductService _productService,
            RoleManager<IdentityRole> _roleManager,
               UserManager<User> _userManager,ISubcategoryServices _subcategoryService, DBContext _context)
        {
            hostingEnvironment = _hostingEnvironment;
            categoryService = _categoryServices;
            productService = _productService;
            roleManager = _roleManager;
            userManager = _userManager;
            subcategoryService = _subcategoryService;
            context = _context;
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
            foreach (Subcategorie sub in subcategoryService.ListAllSubCategory())
            {
                model.Subcategories.Add(sub.Nume);
            }
            foreach (Category cat in categoryService.ListAllCategory())
            {
                model.Categories.Add(cat.CategoryName);
            }

            return View("CreateProduct", model);
        }

        public JsonResult GetSubCategory(int CategoryId)
        {
            List<Subcategorie> subcategorieList = new List<Subcategorie>();
            subcategorieList = (from Subcategorie in context.Subcategories
                                where Subcategorie.CategoryId == CategoryId
                                select Subcategorie).ToList();
            subcategorieList.Insert(0, new Subcategorie { SubCategorieID = 0,Nume="Select" });
            return Json(new SelectList(subcategorieList, "SubCategorieID", "Nume"));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel model)
        {
            var subcat = subcategoryService.GetSubCategoryByName(model.SubCategory);
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
                string uniquePhotoFileName1 = null;
                if (model.Photo1 != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName1 = Guid.NewGuid().ToString() + "_" + model.Photo1.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName1);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo1.CopyTo(fs);
                    }
                }
                string uniquePhotoFileName2 = null;
                if (model.Photo2 != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName2 = Guid.NewGuid().ToString() + "_" + model.Photo2.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName2);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo2.CopyTo(fs);
                    }
                }
                string uniqueVideoFileName = null;
                if (model.Video != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "video");
                    uniqueVideoFileName = Guid.NewGuid().ToString() + "_" + model.Video.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueVideoFileName);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Video.CopyTo(fs);
                    }
                }

                Product produs = new Product
                {
                    ProductName = model.Nume,
                    ProductId = model.ProdusId,
                    ProductDescription = model.Descriere,
                    Pret = model.Pret,
                    ProductPicture = uniquePhotoFileName,
                    ProductPicture2 = uniquePhotoFileName1,
                    ProductPicture3 = uniquePhotoFileName2,
                    ProductVideo = uniqueVideoFileName,
                    Subcategorie = subcat[0]
                };

                await productService.AddProductAsync(produs);

                return RedirectToAction("ListProduct", "product");
            }

            return View("CreateProduct", model);
        }
        [AllowAnonymous]

        public ViewResult ListProducts(string subcategory, int? page)
        {
            IEnumerable<Product> product;
            string currentSubCategory;

            if (string.IsNullOrEmpty(subcategory))
            {
                product = productService.ListAllProduct();
                currentSubCategory = "All Product";
            }
            else
            {
                product = productService.ListAllProduct().Where(c => c.Subcategorie.Nume == subcategory);

                currentSubCategory = subcategoryService.ListAllSubCategory().FirstOrDefault(c => c.Nume == subcategory)?.Nume;
            }

            return View(product.ToList().ToPagedList(page ?? 1 , 3) );
        }




        public ViewResult ListSubcategory(string category,int? page)
        {
            IEnumerable<Subcategorie> subcategory;

            if (string.IsNullOrEmpty(category))
            {
                subcategory = subcategoryService.ListAllSubCategory();
            }

            subcategory = subcategoryService.ListAllSubCategory().Where(c => c.Categories.CategoryName == category);

            return View(subcategory.ToList().ToPagedList(page ?? 1,3));
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
                Subcategories = product.Subcategorie
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
        [HttpPost]
        public IActionResult Search(string SearchString)
        {
            var product =  productService.ListAllProductWith() ;

            if (!String.IsNullOrEmpty(SearchString))
            {
                product = product.Where(c => c.ProductName.ToLower().Contains(SearchString) || c.Subcategorie.Nume.ToLower().Contains(SearchString) || c.ProductName.Contains(SearchString) || c.Subcategorie.Nume.Contains(SearchString)
                || c.Subcategorie.Nume.ToUpper().Contains(SearchString) || c.ProductName.ToUpper().Contains(SearchString));
            }


            return View(new SearchListViewModel
            {
                Products = product
            });
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
                return NotFound();

            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
                return NotFound();

            return View(product);
        }

    }
}
