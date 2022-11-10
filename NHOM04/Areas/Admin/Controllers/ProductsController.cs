using Microsoft.AspNetCore.Mvc;

namespace NHOM04.Areas.Admin.Controllers
{

    public class ProductsController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
