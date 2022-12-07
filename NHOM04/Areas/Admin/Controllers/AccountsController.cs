using Microsoft.AspNetCore.Mvc;

namespace NHOM04.Areas.Admin.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
