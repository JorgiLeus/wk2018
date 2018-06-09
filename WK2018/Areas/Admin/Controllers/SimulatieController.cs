using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WK2018.Areas.Admin.Utils;
using WK2018.Data;

namespace WK2018.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class SimulatieController : Controller
    {
        private readonly WKContext _context;

        public SimulatieController(WKContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ToernooiSimulator simulator = new ToernooiSimulator(_context);

            simulator.SimuleerToernooi();

            return View();
        }
    }
}