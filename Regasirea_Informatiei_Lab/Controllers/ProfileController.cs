using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ProfileController : Controller
    {
		private readonly UserManager<User> userManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public ProfileController(UserManager<User> _userManager,
								 IWebHostEnvironment _hostingEnvironment)
		{
			userManager = _userManager;
			hostingEnvironment = _hostingEnvironment;
		}

		[HttpPost]
        [Authorize(Roles = "User")]

        public async Task<IActionResult> PersonalData(EditPersonalDataViewModel _model)
		{
			return View(_model);
		}

		[HttpGet]
        [Authorize(Roles = "User")]


        public async Task<IActionResult> PersonalData()
		{
			var user = await userManager.GetUserAsync(HttpContext.User);

			if (user == null)
			{
				return View("NotFound");
			}


			var model = new EditPersonalDataViewModel
            {
                Id=user.Id,
				ProfilePicture = user.ProfilePicture,
				FirstName = user.FirstName,
				LastName = user.LastName,
				DateOfBirth = user.DateOfBirth,
				Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.UserAddress.Address,
                Country = user.UserAddress.Country,
                Postalcode = user.UserAddress.PostalCode
			};

			return View(model);
		}

        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> EditPersonalData(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Car option with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditDataViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                PhoneNumber = user.PhoneNumber,
                Address = user.UserAddress.Address,
                Country = user.UserAddress.Country,
                Postalcode = user.UserAddress.PostalCode
            };

            return View("Edit", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> EditPersonalData(EditDataViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
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
                user.Id = model.Id;
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.DateOfBirth = model.DateOfBirth;
                user.PhoneNumber = model.PhoneNumber;
                user.ProfilePicture = uniquePhotoFileName;
                user.UserAddress.Address = model.Address;
                user.UserAddress.Country = model.Country;
                user.UserAddress.PostalCode = model.Country;

                await userManager.UpdateAsync(user);

                return RedirectToAction("PersonalData", "profile");

            }
            return View("PersonalData", model);
        }

    }
}
