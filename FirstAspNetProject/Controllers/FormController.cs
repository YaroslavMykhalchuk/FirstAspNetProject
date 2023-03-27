using FirstAspNetProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetProject.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index(User user)
        {
            return View(user);
        }
    }
}
