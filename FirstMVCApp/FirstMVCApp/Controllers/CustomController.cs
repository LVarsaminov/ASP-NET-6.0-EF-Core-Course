using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string SayCustom()
        {
            return "Custom";
        }
    }
}
