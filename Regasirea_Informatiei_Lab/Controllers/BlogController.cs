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
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly IBlogServices blogServices;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        public UserManager<User> UserManager { get; }

        public BlogController(IWebHostEnvironment _hostingEnvironment, IBlogServices _blogServices,
            RoleManager<IdentityRole> _roleManager,
               UserManager<User> _userManager)
        {
            hostingEnvironment = _hostingEnvironment;
            blogServices = _blogServices;
            roleManager = _roleManager;
            userManager = _userManager;
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
                return NotFound();

            var blog = await blogServices.GetBlogByIdAsync(id);
            if (blog == null)
                return NotFound();

            return View(blog);
        }

        [HttpGet]
        public IActionResult BlogList()
        {
            var bloglist = blogServices.ListAllBlog();
            return View("ListBlog", bloglist);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AdminListBlog()
        {
            var bloglist = blogServices.ListAllBlog();
            return View("AdminListDetails", bloglist);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateBlog()
        {
            return View("CreateBlog");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateBlog(CreateBlogViewModel model)
        {
            if (ModelState.IsValid)
            {

                string uniquePhotoFileName = null;
                if (model.BlogImage != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "blog");
                    uniquePhotoFileName = Guid.NewGuid().ToString() + "_" + model.BlogImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.BlogImage.CopyTo(fs);
                    }
                }

                string uniqueVideoFileName = null;
                if (model.BlogVideo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "blog");
                    uniqueVideoFileName = Guid.NewGuid().ToString() + "_" + model.BlogVideo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueVideoFileName);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.BlogVideo.CopyTo(fs);
                    }
                }

                Blog blog = new Blog
                {
                    BlogName = model.Nume,
                    BlogDescription = model.BlogDescription,
                    BlogPicture = uniquePhotoFileName,
                    BlogVideo = uniqueVideoFileName

                };

                await blogServices.AddBlogAsync(blog);

                return RedirectToAction("BlogList", "blog");
            }

            return View("ListBlog", model);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await blogServices.GetBlogByIdAsync(id);

            await blogServices.DeleteBlogAsync(blog);

            return RedirectToAction("BlogList", "blog");
        }
      

    }
}
