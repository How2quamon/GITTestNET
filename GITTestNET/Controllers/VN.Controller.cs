using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GITTestNET.Controllers
{
    public class VN : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
