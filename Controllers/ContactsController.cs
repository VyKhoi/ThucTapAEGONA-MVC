using Microsoft.AspNetCore.Mvc;

namespace ThucTapMVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
