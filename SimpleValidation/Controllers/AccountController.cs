using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using SimpleValidation.Models;

namespace SimpleValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }
    }
}
