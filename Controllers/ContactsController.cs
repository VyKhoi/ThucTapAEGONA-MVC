using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using ThucTapMVC.Data;
using ThucTapMVC.Models;


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
        public async Task <IActionResult> Index()
        {
            return _db.Contacts != null ?
                         View(await _db.Contacts.ToListAsync()) :
                         Problem("Entity set 'MyDbContext.contactModel'  is null.");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SendContacts()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendContacts([Bind("FullName,Email,CompanyPhone,BusinessPhone,Message")] Contacts model)
        {

            if (ModelState.IsValid)
            {
                
                _db.Add(model);
                await _db.SaveChangesAsync();



                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


    }
}
