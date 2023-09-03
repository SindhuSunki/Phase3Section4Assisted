using Microsoft.AspNetCore.Mvc;

namespace UsingCustomFilters.Controllers
{
    public class AccountContoller : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
