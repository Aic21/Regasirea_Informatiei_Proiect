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
using Lucene.Net.Util;
using Lucene.Net.Store;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Documents;
using Lucene.Net.Search;
using Lucene.Net.Analysis.Standard;
using Microsoft.EntityFrameworkCore;
using Regasirea_Informatiei_Lab.Data;
using Lucene.Net.QueryParsers.Classic;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using System.Web;
using Syncfusion.Pdf.Grid;

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
        private static IndexWriterConfig _indexConfig;
        private static FSDirectory _indexDir;
        private string _documentsDirectoryPath= @"";



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
        public IActionResult ListProduct(int?page)
        {
            var product = productService.ListAllProductWith();
            return View("ListProduct", product.ToList().ToPagedList(page ?? 1, 3));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateProduct()
        {
            CreateProductViewModel model = new CreateProductViewModel { };
            foreach (Subcategorie cat in subcategoryService.ListAllSubCategory())
            {
                model.Subcategories.Add(cat.Nume);
            }

            return View("CreateProduct", model);
        }
       

        public static string GetSerialKeyAlphaNumaric(int keyLength)
        {
            string newSerialNumber = "";
            string SerialNumber = Guid.NewGuid().ToString("N").Substring(0, (int)keyLength).ToUpper();
            for (int iCount = 0; iCount < (int)keyLength; iCount += 4)
                newSerialNumber = newSerialNumber + SerialNumber.Substring(iCount, 4) + "-";
            newSerialNumber = newSerialNumber.Substring(0, newSerialNumber.Length - 1);
            return newSerialNumber;
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel model)
        {
            int keyLength = 12;

            var cat = subcategoryService.GetSubCategoryByName(model.SubCategory);
            string newSerialNumber = "";
            string SerialNumber = Guid.NewGuid().ToString("N").Substring(0, keyLength).ToUpper();
            for (int iCount = 0; iCount < (int)keyLength; iCount += 4)
                newSerialNumber = newSerialNumber + SerialNumber.Substring(iCount, 4) + "-";
            newSerialNumber = newSerialNumber.Substring(0, newSerialNumber.Length - 1);

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

                string uniqueDoc = null;
                if (model.Doc != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.ContentRootPath, "Data","Lucene");
                    uniqueDoc = Guid.NewGuid().ToString() + "_" + model.Doc.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueDoc);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Doc.CopyTo(fs);
                    }
                }
                string spect = null;
                if (model.Specification != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.ContentRootPath, "Data", "Specifications");
                    spect = Guid.NewGuid().ToString() + "_" + model.Specification.FileName;
                    string filePath = Path.Combine(uploadsFolder, spect);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Specification.CopyTo(fs);
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
                string uniquePhotoFileName3 = null;
                if (model.Video != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "video");
                    uniquePhotoFileName1 = Guid.NewGuid().ToString() + "_" + model.Video.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName3);
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
                    //Categories = productCategorie[0],
                    ProductPicture = uniquePhotoFileName,
                    ProductPicture2 = uniquePhotoFileName1,
                    ProductPicture3 = uniquePhotoFileName2,
                    ProductVideo = uniquePhotoFileName3,
                    Subcategorie = cat[0],
                    DocumentPath = uniqueDoc,
                    SerialNo = newSerialNumber,
                    ProductStock = model.Stock,
                    Specifications = spect,
                    IsPromoted = model.IsPromoted
                    //de adaugat Model No
                };

                await productService.AddProductAsync(produs);

                return RedirectToAction("ListProduct", "product");
            }

            return View("CreateProduct", model);
        }
        [AllowAnonymous]

        public ViewResult ListProducts(string subcategory, int? page,string sortOrder,int price_interval)
        {
            IEnumerable<Product> product;
            string currentSubCategory;

            ViewBag.PriceDescParam = string.IsNullOrEmpty(sortOrder) ? "price_desc":"";
            ViewBag.PriceAscParam = string.IsNullOrEmpty(sortOrder) ? "price_asc" : "";
            ViewBag.PriceFilter = string.IsNullOrEmpty(sortOrder) ? "price_interval" : "";




            switch (sortOrder)
            {
                case "price_desc":
                    if (string.IsNullOrEmpty(subcategory))
                    {
                        product = productService.ListAllProduct().OrderByDescending(s => s.Pret);
                    }
                    else
                    {
                        product = productService.ListAllProduct().Where(c => c.Subcategorie.Nume == subcategory).OrderByDescending(s => s.Pret);

                        currentSubCategory = subcategoryService.ListAllSubCategory().FirstOrDefault(c => c.Nume == subcategory)?.Nume;
                        ViewData["curent"] = currentSubCategory;
                    }
                    break;
                case "price_interval":

                    if (string.IsNullOrEmpty(subcategory))
                    {
                        product = productService.ListAllProduct().Where(s=>s.Pret<price_interval);
                    }
                    else
                    {
                        product = productService.ListAllProduct().Where(c => c.Subcategorie.Nume == subcategory).Where(s => s.Pret < price_interval);

                        currentSubCategory = subcategoryService.ListAllSubCategory().FirstOrDefault(c => c.Nume == subcategory)?.Nume;
                        ViewData["curent"] = currentSubCategory;
                    }
                    break;
                case "price_asc":
                    if (string.IsNullOrEmpty(subcategory))
                    {
                        product = productService.ListAllProduct().OrderBy(s => s.Pret);
                    }
                    else
                    {
                        product = productService.ListAllProduct().Where(c => c.Subcategorie.Nume == subcategory).OrderBy(s => s.Pret);

                        currentSubCategory = subcategoryService.ListAllSubCategory().FirstOrDefault(c => c.Nume == subcategory)?.Nume;
                        ViewData["curent"] = currentSubCategory;
                    }
                    break;

                default:
                    if (string.IsNullOrEmpty(subcategory))
                    {
                        product = productService.ListAllProduct();
                    }
                    else
                    {
                        product = productService.ListAllProduct().Where(c => c.Subcategorie.Nume == subcategory);

                        currentSubCategory = subcategoryService.ListAllSubCategory().FirstOrDefault(c => c.Nume == subcategory)?.Nume;
                        ViewData["curent"] = currentSubCategory;


                    }
                    break;
            }


            return View(product.ToList().ToPagedList(page ?? 1 , 8) );
        }


        [Authorize(Roles = "Admin")]

        public RedirectToActionResult UpdateStock   (int productId, int amount)
        {
            var selectedProduct = productService.ListAllProduct().FirstOrDefault(c => c.ProductId == productId);
            if (selectedProduct != null)
            {

                selectedProduct.ProductStock = amount;

            }
            context.SaveChanges();

            return RedirectToAction("ListProducts");
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
                Subcategories = product.Subcategorie,
                IsPromoted = product.IsPromoted,
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
       /* [HttpPost]
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
        }*/

        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            var product = (from Product in this.context.Products
                             where Product.ProductName.Contains(prefix)
                             select new
                             {
                                 label = Product.ProductName,
                                 val = Product.ProductId
                             }).ToList();

            return Json(product);
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
                return NotFound();

            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
                return NotFound();
            string content = Path.Combine(hostingEnvironment.ContentRootPath, "Data", "Specifications", product.Specifications);
            string[] texts = System.IO.File.ReadAllLines(content);
            ViewBag.Data = texts;

            return View(product);
        }

        public async Task<IActionResult> ConvertToPdf(int productId)
        {
        

            var product = await productService.GetProductByIdAsync(productId);

            PdfDocument doc = new PdfDocument();
            //Add a page.
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();
            //Add values to list
            List<object> data = new List<object>();
            Object row1 = new { ID = product.ProductId, Name = product.ProductName, Price = product.Pret, SerialNo=product.SerialNo };
   
            data.Add(row1);

            //Add list to IEnumerable
            IEnumerable<object> dataTable = data;
            //Assign data source.
            pdfGrid.DataSource = dataTable;
            //Draw grid to the page of PDF document.
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));
            //Save the PDF document to stream
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            //If the position is not set to '0' then the PDF will be empty.
            stream.Position = 0;
            //Close the document.
            doc.Close(true);
            //Defining the ContentType for pdf file.
            string contentType = "application/pdf";
            //Define the file name.
            string fileName = "Output.pdf";
            //Creates a FileContentResult object by using the file contents, content type, and file name.
            return File(stream, contentType, fileName);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Search(string SearchString,string sortOrder)
        {
            ViewBag.SearchString = SearchString;

            if (SearchString == null)
            {
                return RedirectToAction("ListProducts");
            }

            Sort sort;
            switch (sortOrder)
            {
                case "ascending":

                    sort = new Sort(new SortField[] { new SortField(null, SortFieldType.SCORE, true), new SortField(null, SortFieldType.DOC, true) });
                    break;
                case "descending":
                    sort = new Sort(new SortField[] { SortField.FIELD_SCORE, SortField.FIELD_DOC, });

                    break;
                default:
                    sort = new Sort(new SortField[] { SortField.FIELD_SCORE, SortField.FIELD_DOC, });
                    break;
            }
            const LuceneVersion luceneVersion = LuceneVersion.LUCENE_48;

            string indexPath = Path.Combine(hostingEnvironment.ContentRootPath,"Data","Lucene","Index");
            _documentsDirectoryPath = Path.Combine(hostingEnvironment.ContentRootPath,"Data","Lucene");    

            _indexDir = FSDirectory.Open(indexPath);

            Analyzer standardAnalyzer = new StandardAnalyzer(luceneVersion);
            FileParser file_parser = new FileParser();

            //Create an index writer
            _indexConfig = new IndexWriterConfig(luceneVersion, standardAnalyzer);

            List<Document> documents_list = new List<Document>();
            IndexWriter writer = new IndexWriter(_indexDir, _indexConfig);

            foreach (string file in System.IO.Directory.EnumerateFiles(_documentsDirectoryPath, "*.txt"))
            {
                documents_list.Add(file_parser.ParseDocument(file));
            }

            writer.DeleteAll();
            writer.Commit();


            foreach (var document in documents_list)
            {
                writer.AddDocument(document);
            }

            writer.Flush(true,true);
            writer.Commit();

            string[] searchFields = { "ProductId", "ProductName", "ProductSpecification" };

            using DirectoryReader reader = DirectoryReader.Open(_indexDir);
            IndexSearcher searcher = new IndexSearcher(reader);

            var parser = new MultiFieldQueryParser(LuceneVersion.LUCENE_48, searchFields, standardAnalyzer);
            parser.DefaultOperator=Operator.OR;

            //Query query = new TermQuery(new Term("componentName", term));
        
                var query = parser.Parse(SearchString);
            

            var hits = searcher.Search(query, 100,sort).ScoreDocs;
            var documents = new List<Document>();
            foreach (var hit in hits)
            {
                documents.Add(searcher.Doc(hit.Doc));
            }

            List<Product> results = new List<Product>();
            foreach (var result in documents)
            {
                int productId = int.Parse(result.Get("ProductId"));
                var product = await context.Products.FindAsync(productId);

                results.Add(product);
            }

            writer.Dispose();

            return View(new SearchListViewModel
            {
                Products = results
            });

            
        }


    }
    }
