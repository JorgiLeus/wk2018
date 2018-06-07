using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WK2018.Areas.Admin.Controllers
{
    public class SimulatieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}