using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineBar_API_Balraj.Controllers
{
    public class WineAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
