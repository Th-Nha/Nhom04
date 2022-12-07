using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NHOM04.Data;
using NHOM04.Models;

namespace NHOM04.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
