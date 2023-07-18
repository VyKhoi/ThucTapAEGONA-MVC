using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using ThucTapMVC.Data;
using ThucTapMVC.Models;
using ThucTapMVC.Models.Dto;

namespace ThucTapMVC.Controllers
{
   
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly Contacts _contacts;
        public ContactsController(ApplicationDbContext db, Contacts contacts)
        {
            _db = db;
            _contacts = contacts;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/contact/")]
        [AllowAnonymous]
        public IActionResult SendContact()
        {
            return View();
        }

        [HttpPost("/contact/")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendContact([Bind("FullName,Email,PhoneNumber,Message")] Contacts contactModel)
        {
            if (ModelState.IsValid) 
            { 
            //{
            //    _contacts.SendDate = DateTime.Now;
                _db.Add(contactModel);
                await _db.SaveChangesAsync();

                //AlertStatusMessage = "Cảm ơn bạn đã góp ý !";

                return RedirectToAction("Index", "Home");
            }
            return View(contactModel);
        }



    }
}
