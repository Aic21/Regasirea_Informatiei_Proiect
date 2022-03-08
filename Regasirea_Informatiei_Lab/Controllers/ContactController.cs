using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ContactController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly IContactService contactService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        public UserManager<User> UserManager { get; }

        public ContactController(IWebHostEnvironment _hostingEnvironment, IContactService _contactService,
            RoleManager<IdentityRole> _roleManager,
               UserManager<User> _userManager)
        {
            hostingEnvironment = _hostingEnvironment;
            contactService = _contactService;
            roleManager = _roleManager;
            userManager = _userManager;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ContactList()
        {
            var contact = contactService.ListAllContact();
            return View("ListContact", contact);
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public IActionResult CreateContact()
        {
            return View("CreateContact");
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> CreateContact(CreateContactViewModel model)
        {
            if (ModelState.IsValid)
            {

                Contact contact = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Subject = model.Subject,
                    Problem = model.Problem

                };

                await contactService.AddContactAsync(contact);

                return RedirectToAction("Index", "home");
            }

            return View("CreateContact", model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await contactService.GetContactByIdAsync(id);

            await contactService.DeleteContactAsync(contact);

            return RedirectToAction("ContactList", "contact");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditContact(int id)
        {
            var contact = await contactService.GetContactByIdAsync(id);

            if (contact == null)
            {
                ViewBag.ErrorMessage = $"Category with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditContactViewModel
            {
                ContactId = contact.ContactId,
                Name = contact.Name,
                Email = contact.Email,
                Subject = contact.Subject,
                Problem = contact.Problem
            };

            return View("EditContact", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCategory(EditContactViewModel model)
        {
            var contact = await contactService.GetContactByIdAsync(model.ContactId);

            if (contact == null)
            {
                ViewBag.ErrorMessage = $"Category with Id = {model.ContactId} cannot be found";
                return View("NotFound");
            }
            else
            {
                contact.Name = model.Name;
                contact.Email = model.Email;
                contact.Subject = model.Subject;
                contact.Problem = model.Problem;

                await contactService.UpdateContactAsync(contact);

                return RedirectToAction("CategoryList", "category");

            }
            return View("ListContact", model);
        }

    }
}
