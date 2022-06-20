using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;

namespace Regasirea_Informatiei_Lab.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<User> userManager;
		private readonly SignInManager<User> signInManager;
		private readonly IWebHostEnvironment hostingEnvironment;
		public AccountController(UserManager<User> _userManager,
								 SignInManager<User> _signInManager,
								 IWebHostEnvironment _hostingEnvironment)
		{
			userManager = _userManager;
			signInManager = _signInManager;
			hostingEnvironment = _hostingEnvironment;
		}



		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("acasa", "home");
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel _model)
		{
			if (ModelState.IsValid)
			{
				var result = await signInManager.PasswordSignInAsync(_model.Email, _model.Password, _model.RememberMe, false);

				if (result.Succeeded)
				{
					return RedirectToAction("acasa", "home");
				}

				ModelState.AddModelError(string.Empty, "Invalid login attempt");
			}

			return View(_model);
		}
		[HttpGet]
		[AllowAnonymous]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Register(RegisterViewModel _model)
		{
			if (ModelState.IsValid)
			{
				var address = new UserAdress
				{
					Address = _model.Address,
					County = _model.County,
					Country = _model.Country,
					PostalCode = _model.PostalCode
				};

				string uniquePhotoFileName = null;
				if (_model.ProfilePhoto != null)
				{
					string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
					uniquePhotoFileName = Guid.NewGuid().ToString() + "_" + _model.ProfilePhoto.FileName;
					string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName);
					using (FileStream fs = new FileStream(filePath, FileMode.Create))
					{
						_model.ProfilePhoto.CopyTo(fs);
					}
				}

				var user = new User
				{
					FirstName = _model.FirstName,
					LastName = _model.LastName,
					UserName = _model.Email,
					Email = _model.Email,
					PhoneNumber = _model.PhoneNumber,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					DateOfBirth = _model.DateOfBirth,
					UserAddress = address,
					ProfilePicture = uniquePhotoFileName
				};

				var result = await userManager.CreateAsync(user, _model.Password);
				await userManager.AddToRoleAsync(user, "User");

				if (result.Succeeded)
				{
					await signInManager.SignInAsync(user, isPersistent: false);

					return RedirectToAction("acasa", "home");
				}

				foreach (var error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
			}
			else
			{
				var errors = ModelState.Where(x => x.Value.Errors.Any())
					.Select(x => new { x.Key, x.Value.Errors });
			}

			return View(_model);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult AccessDenied()
		{
			return View();
		}
	}
}

