using Microsoft.AspNetCore.Mvc;

namespace abc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
